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
    public partial class CafeteriaForm : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public CafeteriaForm()
        {
            InitializeComponent();
        }

        private void CafeteriaForm_Load(object sender, EventArgs e)
        {
            LoadStudentData();
            LoadCafeteriaItems();
        }

        private void LoadStudentData()
        {
            var userSession = UserSession.Instance;
            if (userSession.Role == "Student")
            {
                int studentId = GetStudentIdByEmail(userSession.Email);
                if (studentId != 0)
                {
                    DataTable purchases = GetStudentPurchases(studentId);
                    studentPurchasesGridView.DataSource = purchases;

                    DataTable restrictedItems = GetRestrictedItems(studentId);
                    restrictedItemsGridView.DataSource = restrictedItems;

                    txtStudentName.Text = $"{userSession.FirstName} {userSession.LastName}";
                    txtBalance.Text = userSession.Balance.ToString("C");
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private DataTable GetRestrictedItems(int studentId)
        {
            string query = @"
        SELECT ci.ItemName
        FROM ItemRestrictions ir
        JOIN CafeteriaItems ci ON ir.ItemID = ci.ItemID
        JOIN Students s ON ir.ParentID = s.ParentID
        WHERE s.StudentID = @StudentID AND ir.IsRestricted = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", studentId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        private void LoadCafeteriaItems()
        {
            string query = "SELECT ItemID, ItemName FROM CafeteriaItems";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                itemComboBox.DisplayMember = "ItemName";
                itemComboBox.ValueMember = "ItemID";
                itemComboBox.DataSource = dataTable;
            }
        }
        public DataTable GetStudentPurchases(int studentId)
        {
            string query = @"
            SELECT p.PurchaseID, i.ItemName, p.Quantity, i.Price, p.PurchaseDate
            FROM CafeteriaPurchases p
            JOIN CafeteriaItems i ON p.ItemID = i.ItemID
            WHERE p.StudentID = @StudentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", studentId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }


        public void UpdateStockAndBalance(int studentId, int itemId, int quantity)
        {
            string query = @"
            BEGIN TRANSACTION;
            UPDATE CafeteriaItems SET Stock = Stock - @Quantity WHERE ItemID = @ItemID;
            UPDATE Students SET Balance = Balance - (SELECT Price FROM CafeteriaItems WHERE ItemID = @ItemID) * @Quantity WHERE StudentID = @StudentID;
            INSERT INTO CafeteriaPurchases (StudentID, ItemID, Quantity, PurchaseDate) VALUES (@StudentID, @ItemID, @Quantity, GETDATE());
            COMMIT TRANSACTION;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", studentId);
                command.Parameters.AddWithValue("@ItemID", itemId);
                command.Parameters.AddWithValue("@Quantity", quantity);
                connection.Open();
                command.ExecuteNonQuery();
            }

            // Kullanıcı bakiyesini güncelle
            var userSession = UserSession.Instance;
            userSession.Balance -= GetItemPrice(itemId) * quantity;
        }

        private decimal GetItemPrice(int itemId)
        {

            string query = "SELECT Price FROM CafeteriaItems WHERE ItemID = @ItemID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItemID", itemId);
                connection.Open();
                return (decimal)command.ExecuteScalar();
            }
        }

        private void purchaseButton_Click_1(object sender, EventArgs e)
        {
            var userSession = UserSession.Instance;
            if (userSession.Role == "Student")
            {
                int studentId = GetStudentIdByEmail(userSession.Email);
                if (studentId != 0)
                {
                    int itemId = (int)itemComboBox.SelectedValue;
                    int quantity = 1; // Örneğin 1 adet ürün alınıyor
                    if (IsItemRestrictedForStudent(studentId, itemId))
                    {
                        MessageBox.Show("Bu ürünü alamazsınız. Ebeveyniniz tarafından kısıtlanmıştır.", "Kısıtlama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    UpdateStockAndBalance(studentId, itemId, quantity);
                    LoadStudentData(); // Güncellenmiş verileri tekrar yükle
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public int GetStudentIdByEmail(string email)
        {
            string query = "SELECT StudentID FROM Students WHERE Email = @Email";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                var result = command.ExecuteScalar();
                return (result != null) ? Convert.ToInt32(result) : 0;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Students students = new Students();
            panel1.Controls.Add(students);
        }
        public bool IsItemRestrictedForStudent(int studentId, int itemId)
        {
            string query = @"
    SELECT COUNT(*)
    FROM ItemRestrictions r
    JOIN Students s ON r.ParentID = s.ParentID
    WHERE s.StudentID = @StudentID AND r.ItemID = @ItemID AND r.IsRestricted = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", studentId);
                command.Parameters.AddWithValue("@ItemID", itemId);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private void restrictedItemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

