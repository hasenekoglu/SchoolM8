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
    public partial class AddCanteenDetails : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public AddCanteenDetails()
        {
            InitializeComponent();
        }
        private void AddCanteenDetails_Load(object sender, EventArgs e)
        {
            LoadItems();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }


        private void LoadItems()
        {
            listBoxItems.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ItemID, ItemName, Price, Stock FROM CafeteriaItems";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string item = $"{reader["ItemID"]} - {reader["ItemName"]} - Price: {reader["Price"]} TL - Stock: {reader["Stock"]}";
                    listBoxItems.Items.Add(item);
                }
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO CafeteriaItems (ItemName, Price, Stock) VALUES (@ItemName, @Price, @Stock)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ItemName", textBoxItemName.Text);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(textBoxPrice.Text));
                cmd.Parameters.AddWithValue("@Stock", (int)numericUpDownStock.Value);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadItems();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateStock(int amount)
        {
            string selectedItem = listBoxItems.SelectedItem.ToString();
            int itemId = int.Parse(selectedItem.Split(' ')[0]);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE CafeteriaItems SET Stock = Stock + @Amount WHERE ItemID = @ItemID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@ItemID", itemId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
                UpdateStock(1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
                UpdateStock(-1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
                string selectedItem = listBoxItems.SelectedItem.ToString();
                int itemId = int.Parse(selectedItem.Split(' ')[0]);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM CafeteriaItems WHERE ItemID = @ItemID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ItemID", itemId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadItems();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Admin admin = new Admin();
            panel1.Controls.Add(admin);
        }
    }
}
