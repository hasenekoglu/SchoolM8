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
    public partial class ViewStudent : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public ViewStudent()
        {
            InitializeComponent();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            LoadStudents();
            comboBoxViewStudents.SelectedIndexChanged += comboBoxViewStudents_SelectedIndexChanged;
            buttonLoadStudentInfo.Click += buttonLoadStudentInfo_Click;

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
                        comboBoxViewStudents.Items.Add(new KeyValuePair<int, string>(studentId, studentName));
                    }
                }
            }

            
        }
        private void LoadStudentInfo()
        {
            if (comboBoxViewStudents.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedStudent = (KeyValuePair<int, string>)comboBoxViewStudents.SelectedItem;
                int studentId = selectedStudent.Key;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT Students.StudentID, Students.FirstName, Students.LastName, Students.DateOfBirth, 
                                    Students.Address, Classes.ClassName, Students.Balance, Students.Email 
                             FROM Students 
                             INNER JOIN Classes ON Students.ClassID = Classes.ClassID 
                             WHERE StudentID = @StudentID";
                    //  string query = "SELECT StudentID, FirstName, LastName, DateOfBirth, Address, ClassID, Balance, Email FROM Students WHERE StudentID = @StudentID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        labelStudentID.Text = $"{reader["StudentID"]}";
                        labelFirstName.Text = $"{reader["FirstName"]}";
                        labelLastName.Text = $"{reader["LastName"]}";
                        labelDateOfBirth.Text = $"{reader["DateOfBirth"]:d}";
                        labelAddress.Text = $"{reader["Address"]}";
                        labelClassID.Text = $"{reader["ClassName"]}";
                        labelBalance.Text = $"{reader["Balance"]:C}";
                        labelEmail.Text = $"{reader["Email"]}";
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void comboBoxViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            LoadStudentInfo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Parent parent = new Parent();
            panel1.Controls.Add(parent);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
