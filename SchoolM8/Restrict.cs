using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolM8
{
    public partial class Restrict : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public Restrict()
        {

            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Restrict_Load_1(object sender, EventArgs e)
        {
            var userSession = UserSession.Instance;
            if (userSession.Role == "Parent")
            {
                DataTable restrictions = GetParentRestrictions(userSession.UserId);
                studentRestrictionsGridView.DataSource = restrictions;
            }
            LoadCafeteriaItems();
            LoadStudents();
            buttonApplyRestriction.Click += saveButton_Click;


        }

        private void LoadCafeteriaItems()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ItemID, ItemName FROM CafeteriaItems";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxItems.Items.Add(new KeyValuePair<int, string>((int)reader["ItemID"], reader["ItemName"].ToString()));
                }
            }

            comboBoxItems.DisplayMember = "Value";
            comboBoxItems.ValueMember = "Key";
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectedItem = (KeyValuePair<int, string>)comboBoxItems.SelectedItem;
            int itemId = selectedItem.Key;
            bool isRestricted = checkBoxIsRestricted.Checked;

            UserSession session = UserSession.Instance;
            string parentEmail = session.Email;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string parentQuery = "SELECT ParentID FROM Parents WHERE Email = @Email";
                SqlCommand parentCmd = new SqlCommand(parentQuery, con);
                parentCmd.Parameters.AddWithValue("@Email", parentEmail);

                con.Open();
                object result = parentCmd.ExecuteScalar();
                if (result != null)
                {
                    int parentId = (int)result;

                    string restrictionQuery =
                        "IF EXISTS (SELECT * FROM ItemRestrictions WHERE ParentID = @ParentID AND ItemID = @ItemID) " +
                        "BEGIN " +
                        "UPDATE ItemRestrictions SET IsRestricted = @IsRestricted WHERE ParentID = @ParentID AND ItemID = @ItemID " +
                        "END " +
                        "ELSE " +
                        "BEGIN " +
                        "INSERT INTO ItemRestrictions (ParentID, ItemID, IsRestricted) VALUES (@ParentID, @ItemID, @IsRestricted) " +
                        "END";
                    SqlCommand restrictionCmd = new SqlCommand(restrictionQuery, con);
                    restrictionCmd.Parameters.AddWithValue("@ParentID", parentId);
                    restrictionCmd.Parameters.AddWithValue("@ItemID", itemId);
                    restrictionCmd.Parameters.AddWithValue("@IsRestricted", isRestricted);

                    restrictionCmd.ExecuteNonQuery();
                    MessageBox.Show("Restriction applied successfully!");
                }
            }
        }



        private DataTable GetParentRestrictions(int parentId)
        {
            string query = @"
        SELECT s.FirstName + ' ' + s.LastName AS StudentName, ci.ItemName
        FROM ItemRestrictions ir
        JOIN CafeteriaItems ci ON ir.ItemID = ci.ItemID
        JOIN Students s ON ir.ParentID = s.ParentID
        WHERE ir.ParentID = @ParentID AND ir.IsRestricted = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ParentID", parentId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        private void LoadStudents()
        {
            var userSession = UserSession.Instance;
            string parentEmail = userSession.Email;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string parentQuery = "SELECT ParentID FROM Parents WHERE Email = @Email";
                SqlCommand parentCmd = new SqlCommand(parentQuery, con);
                parentCmd.Parameters.AddWithValue("@Email", parentEmail);

                con.Open();
                object result = parentCmd.ExecuteScalar();
                if (result != null)
                {
                    int parentId = (int)result;

                    string studentQuery = "SELECT StudentID, FirstName, LastName FROM Students WHERE ParentID = @ParentID";
                    SqlCommand studentCmd = new SqlCommand(studentQuery, con);
                    studentCmd.Parameters.AddWithValue("@ParentID", parentId);

                    SqlDataReader reader = studentCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string studentName = $"{reader["FirstName"]} {reader["LastName"]}";
                        int studentId = (int)reader["StudentID"];
                        comboBoxStudents.Items.Add(new KeyValuePair<int, string>(studentId, studentName));
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Parent parent = new Parent();
            panel1.Controls.Add(parent);
        }

        private void studentRestrictionsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}