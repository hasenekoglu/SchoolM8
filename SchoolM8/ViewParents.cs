using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolM8
{
    public partial class ViewParents : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public ViewParents()
        {
            InitializeComponent();
            LoadParents();
        }

        private void LoadParents()
        {
            string query = @"
                SELECT 
                    p.ParentID, 
                    p.FirstName, 
                    p.LastName, 
                    p.PhoneNumber, 
                    p.Email, 
                    p.Occupation 
                FROM Parents p";

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
    }
}