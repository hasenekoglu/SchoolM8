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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string role = comboBoxRole.SelectedItem.ToString();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            using (SqlConnection connect = new SqlConnection(@"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                connect.Open();
                SqlTransaction transaction = connect.BeginTransaction();
                SqlCommand command = connect.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                        "INSERT INTO Users (FirstName, LastName, Email, Password, Roles) OUTPUT INSERTED.UserID VALUES (@FirstName, @LastName, @Email, @Password, @Roles)";
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Roles", role);

                    int userId = (int)command.ExecuteScalar();

                    if (role == "Parent")
                    {
                        // Show ParentSignUpForm to select student
                        command.CommandText = "INSERT INTO Parents (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)";
                        command.ExecuteNonQuery();
                    }
                    else if (role == "Student")
                    {
                        // Insert into Students table
                        command.CommandText = "INSERT INTO Students (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)";
                        command.ExecuteNonQuery();
                    }
                    else if (role == "Teacher")
                    {
                        // Insert into Teachers table
                        command.CommandText = "INSERT INTO Teachers (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)";
                        command.ExecuteNonQuery();
                    }
                    else if (role == "Admin")
                    {
                        // Admin role, no additional tables needed
                    }

                    transaction.Commit();
                    MessageBox.Show("User registered successfully!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            //using (SqlConnection connect = new SqlConnection(@"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            //{
            //    connect.Open();
            //    SqlCommand command =
            //        new SqlCommand(
            //            "INSERT INTO Users (FirstName, LastName, Email, Password, Roles) VALUES (@FirstName, @LastName, @Email, @Password, @Roles)",
            //            connect);
            //    command.Parameters.AddWithValue("@FirstName", firstName);
            //    command.Parameters.AddWithValue("@LastName", lastName);
            //    command.Parameters.AddWithValue("@Email", email);
            //    command.Parameters.AddWithValue("@Password", password);
            //    command.Parameters.AddWithValue("@Roles", role);
            //    int userId = (int)command.ExecuteScalar();
            //    try
            //    {
            //        command.ExecuteNonQuery();
            //        MessageBox.Show("User registered successfully!");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message);
            //    }
            //}
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
