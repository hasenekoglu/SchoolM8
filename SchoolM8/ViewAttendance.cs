using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolM8
{
    public partial class ViewAttendance : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public ViewAttendance()
        {
            InitializeComponent();
            LoadAttendance();
        }

        private void LoadAttendance()
        {
            string query = @"
                SELECT 
                    a.AttendanceID, 
                    s.FirstName, 
                    s.LastName, 
                    a.Date, 
                    a.EntryTime, 
                    a.ExitTime 
                FROM Attendance a
                LEFT JOIN Students s ON a.StudentID = s.StudentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ViewAllReports viewAllReports = new ViewAllReports();
            panel1.Controls.Add(viewAllReports);
        }
    }
}