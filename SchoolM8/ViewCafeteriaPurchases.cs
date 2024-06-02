using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolM8
{
    public partial class ViewCafeteriaPurchases : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public ViewCafeteriaPurchases()
        {
            InitializeComponent();
            LoadCafeteriaPurchases();
        }

        private void LoadCafeteriaPurchases()
        {
            string query = @"
                SELECT 
                    cp.PurchaseID, 
                    s.FirstName, 
                    s.LastName, 
                    ci.ItemName, 
                    cp.PurchaseDate, 
                    cp.Quantity 
                FROM CafeteriaPurchases cp
                LEFT JOIN Students s ON cp.StudentID = s.StudentID
                LEFT JOIN CafeteriaItems ci ON cp.ItemID = ci.ItemID";

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