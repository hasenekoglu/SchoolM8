using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolM8
{
    public partial class ViewItemRestrictions : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public ViewItemRestrictions()
        {
            InitializeComponent();
            LoadItemRestrictions();
        }

        private void LoadItemRestrictions()
        {
            string query = @"
                SELECT 
                    ir.RestrictionID, 
                    p.FirstName AS ParentFirstName, 
                    p.LastName AS ParentLastName, 
                    s.FirstName AS StudentFirstName, 
                    s.LastName AS StudentLastName, 
                    ci.ItemName 
                FROM ItemRestrictions ir
                LEFT JOIN Parents p ON ir.ParentID = p.ParentID
                LEFT JOIN Students s ON ir.StudentID = s.StudentID
                LEFT JOIN CafeteriaItems ci ON ir.ItemID = ci.ItemID";

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