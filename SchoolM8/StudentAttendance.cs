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
    public partial class StudentAttendance : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public StudentAttendance()
        {
            InitializeComponent();
        }

        private void StudentAttendance_Load(object sender, EventArgs e)
        {
            LoadStudentInfo();
        }

        private void LoadStudentInfo()
        {
            //UserSession session = UserSession.Instance;

            //labelFirstName.Text = session.FirstName;
            //labelLastName.Text = session.LastName;

        }
        private int GetStudentID(string firstName, string lastName)
        {
            int studentID = -1;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT StudentID FROM Students WHERE FirstName = @FirstName AND LastName = @LastName";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);

                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    studentID = Convert.ToInt32(result);
                }
            }
            return studentID;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                UserSession session = UserSession.Instance;
                int studentID = GetStudentID(session.FirstName, session.LastName);

                if (studentID != -1)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO Attendance (StudentID, Date, EntryTime) VALUES (@StudentID, GETDATE(), GETDATE())";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@StudentID", studentID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Welcome");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            UserSession session = UserSession.Instance;
            int studentID = GetStudentID(session.FirstName, session.LastName);

            if (studentID != -1)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Attendance SET ExitTime = GETDATE() WHERE StudentID = @StudentID AND Date = CAST(GETDATE() AS DATE)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StudentID", studentID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Goodbye");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Students students = new Students();
            panel1.Controls.Add(students);
        }
    }

}
