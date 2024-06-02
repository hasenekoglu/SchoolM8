using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolM8
{
    public partial class ViewStudents : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public ViewStudents()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            string query = @"
                SELECT 
                    s.StudentID, 
                    s.FirstName, 
                    s.LastName, 
                    s.DateOfBirth, 
                    p.FirstName AS ParentFirstName, 
                    p.LastName AS ParentLastName, 
                    c.ClassName 
                FROM Students s
                LEFT JOIN Parents p ON s.ParentID = p.ParentID
                LEFT JOIN Classes c ON s.ClassID = c.ClassID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ViewAllReports viewAllReports = new ViewAllReports();
            panel1.Controls.Add(viewAllReports);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}