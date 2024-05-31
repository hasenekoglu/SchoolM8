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
    public partial class AddParentDetails : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public AddParentDetails()
        {
            InitializeComponent();
        }
        private void AddParentDetails_Load(object sender, EventArgs e)
        {
            LoadParents();

        }
        private void LoadParents()
        {
            string query = "SELECT ParentID, FirstName, LastName FROM Parents";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string studentName = $"{reader["FirstName"]} {reader["LastName"]}";
                    comboBoxStudents.Items.Add(new ComboBoxItem(studentName, (int)reader["ParentID"]));
                }
            }
        }

        private void LoadParentDetails(int parentId)
        {
            string query = "SELECT * FROM Parents WHERE ParentID = @ParentID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ParentID", parentId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBoxFirstName.Text = reader["FirstName"] as string ?? string.Empty;
                    ;
                    textBoxLastName.Text = reader["LastName"] as string ?? string.Empty;
                    textBoxOccupation.Text = reader["Occupation"] as string ?? string.Empty;
                    textBoxPhoneNum.Text = reader["PhoneNumber"] as string ?? string.Empty;

                }
                else
                {
                    textBoxFirstName.Text = string.Empty;
                    textBoxLastName.Text = string.Empty;
                    textBoxOccupation.Text = string.Empty;
                    textBoxPhoneNum.Text = string.Empty;
                }
            }
        }

        private void UpdateParentDetails(int parentId)
        {
            string query =
                "UPDATE Parents SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, Occupation = @Occupation WHERE ParentID = @ParentID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ParentID", parentId);
                command.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                command.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                command.Parameters.AddWithValue("@PhoneNumber", textBoxPhoneNum.Text);
                command.Parameters.AddWithValue("@Occupation", textBoxOccupation.Text);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Parent details updated successfull. ");

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ComboBoxItem selectedItem = (ComboBoxItem)comboBoxStudents.SelectedItem;
            int parentId = selectedItem.Value;
            UpdateParentDetails(parentId);
            panel1.Controls.Clear();
            Admin admin = new Admin();
            panel1.Controls.Add(admin);
        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)comboBoxStudents.SelectedItem;
            int studentId = selectedItem.Value;
            LoadParentDetails(studentId);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Admin admin = new Admin();
            panel1.Controls.Add(admin);
        }
    }
}
