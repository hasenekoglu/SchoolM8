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
    public partial class AddBalance : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public AddBalance()
        {
            InitializeComponent();
        }

        private void AddBalance_Load(object sender, EventArgs e)
        {
            LoadStudents();
            comboBoxStudents.SelectedIndexChanged += comboBoxStudents_SelectedIndexChanged;
        }

        private void LoadStudents()
        {
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedStudent = (KeyValuePair<int, string>)comboBoxStudents.SelectedItem;
                int studentId = selectedStudent.Key;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT Balance FROM Students WHERE StudentID = @StudentID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        decimal currentBalance = (decimal)result;
                        labelCurrentBalance.Text = $"{currentBalance:C}";
                    }
                }

            }
        }

        private void buttonUpdateBalance_Click(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedItem != null &&
                decimal.TryParse(textBoxBalance.Text, out decimal addedBalance))
            {
                KeyValuePair<int, string> selectedStudent = (KeyValuePair<int, string>)comboBoxStudents.SelectedItem;
                int studentId = selectedStudent.Key;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string getBalanceQuery = "SELECT Balance FROM Students WHERE StudentID = @StudentID";
                    SqlCommand getBalanceCmd = new SqlCommand(getBalanceQuery, con);
                    getBalanceCmd.Parameters.AddWithValue("@StudentID", studentId);
                    decimal currentBalance = (decimal)getBalanceCmd.ExecuteScalar();


                    decimal newBalance = currentBalance + addedBalance;

                    string updateBalanceQuery = "UPDATE Students SET Balance = @Balance WHERE StudentID = @StudentID";
                    SqlCommand updateBalanceCmd = new SqlCommand(updateBalanceQuery, con);
                    updateBalanceCmd.Parameters.AddWithValue("@Balance", newBalance);
                    updateBalanceCmd.Parameters.AddWithValue("@StudentID", studentId);
                    updateBalanceCmd.ExecuteNonQuery();


                    labelCurrentBalance.Text = $"{newBalance:C}";
                }

                MessageBox.Show("Balance updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select a student and enter a valid balance.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Parent parent = new Parent();
            panel1.Controls.Add(parent);
        }
    }
}
