using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SchoolM8
{
    public partial class AttendanceViewer : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public AttendanceViewer()
        {
            InitializeComponent();
        }

        private void AttendanceViewer_Load(object sender, EventArgs e)
        {
            LoadStudents();
            comboBoxStudents.SelectedIndexChanged += ComboBoxStudents_SelectedIndexChanged;
        }

        private void LoadStudents()
        {
            try
            {
                UserSession session = UserSession.Instance;
                string parentEmail = session.Email;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string parentQuery = "SELECT ParentID FROM Parents WHERE Email = @Email";
                    SqlCommand parentCommand = new SqlCommand(parentQuery, connection);
                    parentCommand.Parameters.AddWithValue("@Email", parentEmail);
                    int parentId = (int)parentCommand.ExecuteScalar();

                    string studentQuery = "SELECT StudentID, FirstName, LastName FROM Students WHERE ParentID = @ParentID";
                    SqlCommand studentCommand = new SqlCommand(studentQuery, connection);
                    studentCommand.Parameters.AddWithValue("@ParentID", parentId);

                    SqlDataReader reader = studentCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int studentId = (int)reader["StudentID"];
                        string fullName = $"{reader["FirstName"]} {reader["LastName"]}";
                        comboBoxStudents.Items.Add(new KeyValuePair<int, string>(studentId, fullName));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedStudent = (KeyValuePair<int, string>)comboBoxStudents.SelectedItem;
                int studentId = selectedStudent.Key;
                LoadAttendance(studentId);
            }
        }

        private void LoadAttendance(int studentId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Date, EntryTime, ExitTime FROM Attendance WHERE StudentID = @StudentID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", studentId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        TimeSpan entryTime = (TimeSpan)row["EntryTime"];
                        TimeSpan exitTime = (TimeSpan)row["ExitTime"];

                        row["EntryTime"] = FormatTime(entryTime);
                        row["ExitTime"] = FormatTime(exitTime);
                    }

                    dataGridViewAttendance.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading attendance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Parent parent = new Parent();
            panel1.Controls.Add(parent);
        }
        private string FormatTime(TimeSpan timeSpan)
        {
            return timeSpan.ToString(@"hh\:mm\:ss");
        }
    }
}
