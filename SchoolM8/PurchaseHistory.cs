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
    public partial class PurchaseHistory : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public PurchaseHistory()
        {
            InitializeComponent();
        }

        private void PurchaseHistory_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            try
            {
                // Ebeveynin öğrencilerini veritabanından yükleme
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
                            int studentId = (int)reader["StudentID"];
                            string fullName = $"{reader["FirstName"]} {reader["LastName"]}";
                            comboBoxStudents.Items.Add(new KeyValuePair<int, string>(studentId, fullName));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectedStudent = (KeyValuePair<int, string>)comboBoxStudents.SelectedItem;
            int studentId = selectedStudent.Key;
            LoadStudentInfo(studentId);
            LoadPurchaseHistory(studentId);
        }

        private void CalculateTotalSpent(int studentId, DateTime startDate, DateTime endDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT SUM(Quantity * Price) AS TotalSpent FROM CafeteriaPurchases INNER JOIN CafeteriaItems ON CafeteriaPurchases.ItemID = CafeteriaItems.ItemID WHERE StudentID = @StudentID AND PurchaseDate >= @StartDate AND PurchaseDate <= @EndDate";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", studentId);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        decimal totalSpent = Convert.ToDecimal(result);
                        labelTotalSpent.Text = $"Total Spent: {totalSpent:C}";
                    }
                    else
                    {
                        labelTotalSpent.Text = "Total Spent: $0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total spent: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }







        private void LoadStudentInfo(int studentId)
        {
            // Seçilen öğrencinin bilgilerini yükleme
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT FirstName, LastName, DateOfBirth, Address, ClassName, Balance, Email FROM Students INNER JOIN Classes ON Students.ClassID = Classes.ClassID WHERE StudentID = @StudentID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", studentId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        labelFirstName.Text = $"{reader["FirstName"]}";
                        labelLastName.Text = $"{reader["LastName"]}";

                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student info: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadPurchaseHistory(int studentId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT PurchaseID, ItemName, Quantity, Price, PurchaseDate FROM CafeteriaPurchases INNER JOIN CafeteriaItems ON CafeteriaPurchases.ItemID = CafeteriaItems.ItemID WHERE StudentID = @StudentID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", studentId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewPurchaseHistory.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading purchase history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculateTotalSpent_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectedStudent = (KeyValuePair<int, string>)comboBoxStudents.SelectedItem;
            int studentId = selectedStudent.Key;

            DateTime startDate = dateTimePickerStartDate.Value.Date; // Günün başlangıcı
            DateTime endDate = dateTimePickerEndDate.Value.Date.AddDays(1).AddSeconds(-1); // Günün sonu

            CalculateTotalSpent(studentId, startDate, endDate);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Parent parent = new Parent();
            panel1.Controls.Add(parent);
        }
    }
}
