using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        private void Restrict_Load_1(object sender, EventArgs e)
        {
            LoadCafeteriaItems();
            LoadStudents();
            buttonApplyRestriction.Click += saveButton_Click;
            removeRestrictionButton.Click += removeRestrictionButton_Click_1;
            comboBoxStudents.SelectedIndexChanged += comboBoxStudents_SelectedIndexChanged;

            var userSession = UserSession.Instance;
            if (userSession.Role == "Parent")
            {
                LoadParentRestrictions(userSession.Email);
            }
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

            comboBoxStudents.DisplayMember = "Value";
            comboBoxStudents.ValueMember = "Key";
        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedStudent = (KeyValuePair<int, string>)comboBoxStudents.SelectedItem;
                int studentId = selectedStudent.Key;
                LoadStudentRestrictions(studentId);
            }
        }

        private void LoadStudentRestrictions(int studentId)
        {
            string query = @"
                SELECT ci.ItemName, ir.ItemID
                FROM ItemRestrictions ir
                JOIN CafeteriaItems ci ON ir.ItemID = ci.ItemID
                WHERE ir.StudentID = @StudentID AND ir.IsRestricted = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", studentId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                studentRestrictionsGridView.DataSource = dataTable;
            }
        }

        private void LoadParentRestrictions(string email)
        {
            string query = @"
                SELECT s.FirstName + ' ' + s.LastName AS StudentName, ci.ItemName
                FROM ItemRestrictions ir
                JOIN CafeteriaItems ci ON ir.ItemID = ci.ItemID
                JOIN Students s ON ir.StudentID = s.StudentID
                JOIN Parents p ON ir.ParentID = p.ParentID
                WHERE p.Email = @Email AND ir.IsRestricted = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                parentRestrictionsGridView.DataSource = dataTable;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (comboBoxItems.SelectedItem != null && comboBoxStudents.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedItem = (KeyValuePair<int, string>)comboBoxItems.SelectedItem;
                KeyValuePair<int, string> selectedStudent = (KeyValuePair<int, string>)comboBoxStudents.SelectedItem;
                int itemId = selectedItem.Key;
                int studentId = selectedStudent.Key;

                UserSession session = UserSession.Instance;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string parentQuery = "SELECT ParentID FROM Parents WHERE Email = @Email";
                    SqlCommand parentCmd = new SqlCommand(parentQuery, con);
                    parentCmd.Parameters.AddWithValue("@Email", session.Email);

                    con.Open();
                    object result = parentCmd.ExecuteScalar();
                    if (result != null)
                    {
                        int parentId = (int)result;

                        string restrictionQuery =
                            "IF EXISTS (SELECT * FROM ItemRestrictions WHERE ParentID = @ParentID AND ItemID = @ItemID AND StudentID = @StudentID) " +
                            "BEGIN " +
                            "UPDATE ItemRestrictions SET IsRestricted = 1 WHERE ParentID = @ParentID AND ItemID = @ItemID AND StudentID = @StudentID " +
                            "END " +
                            "ELSE " +
                            "BEGIN " +
                            "INSERT INTO ItemRestrictions (ParentID, ItemID, IsRestricted, StudentID) VALUES (@ParentID, @ItemID, 1, @StudentID) " +
                            "END";
                        SqlCommand restrictionCmd = new SqlCommand(restrictionQuery, con);
                        restrictionCmd.Parameters.AddWithValue("@ParentID", parentId);
                        restrictionCmd.Parameters.AddWithValue("@ItemID", itemId);
                        restrictionCmd.Parameters.AddWithValue("@StudentID", studentId);

                        restrictionCmd.ExecuteNonQuery();
                        MessageBox.Show("Restriction applied successfully!");

                        // Kısıtlı ürünler listesini güncelle
                        LoadStudentRestrictions(studentId);
                        LoadParentRestrictions(session.Email);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item and a student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void removeRestrictionButton_Click_1(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedItem != null && studentRestrictionsGridView.SelectedRows.Count > 0)
            {
                KeyValuePair<int, string> selectedStudent = (KeyValuePair<int, string>)comboBoxStudents.SelectedItem;
                int studentId = selectedStudent.Key;
                int itemId = Convert.ToInt32(studentRestrictionsGridView.SelectedRows[0].Cells["ItemID"].Value);

                UserSession session = UserSession.Instance;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string parentQuery = "SELECT ParentID FROM Parents WHERE Email = @Email";
                    SqlCommand parentCmd = new SqlCommand(parentQuery, con);
                    parentCmd.Parameters.AddWithValue("@Email", session.Email);

                    con.Open();
                    object result = parentCmd.ExecuteScalar();
                    if (result != null)
                    {
                        int parentId = (int)result;

                        string deleteQuery = "DELETE FROM ItemRestrictions WHERE ParentID = @ParentID AND ItemID = @ItemID AND StudentID = @StudentID";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                        deleteCmd.Parameters.AddWithValue("@ParentID", parentId);
                        deleteCmd.Parameters.AddWithValue("@ItemID", itemId);
                        deleteCmd.Parameters.AddWithValue("@StudentID", studentId);

                        deleteCmd.ExecuteNonQuery();
                        MessageBox.Show("Restriction removed successfully!");

                        // Kısıtlı ürünler listesini güncelle
                        LoadStudentRestrictions(studentId);
                        LoadParentRestrictions(session.Email);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student and a restriction to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonApplyRestriction_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
