﻿using Microsoft.Data.SqlClient;
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
    public partial class M8School : Form
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public M8School()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void M8School_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;


            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)
                )
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connect = new SqlConnection(@"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                connect.Open();
                SqlCommand command =
                    new SqlCommand("SELECT UserID, FirstName, LastName, Roles FROM Users WHERE Email = @Email AND Password = @Password", connect);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int userId = (int)reader["UserID"];
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();
                    string role = reader["Roles"].ToString();

                    // Save the user details in the UserSession singleton
                    LoadUserInfo(userId);
                    LoadRoleSpecificInfo(firstName, lastName, role);
                    // Redirect to the appropriate form based on the role


                    Form nextForm = new Form1();
                    nextForm.FormClosed += (s, args) => this.Show();
                    nextForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                }


            }
        }

        private void LoadRoleSpecificInfo(string firstName, string lastName, string role)
        {
            string query = string.Empty;

            switch (role)
            {
                case "Student":
                    query =
                        "SELECT s.*, p.FirstName AS ParentFirstName, p.LastName AS ParentLastName, c.ClassName FROM Students s " +
                        "JOIN Parents p ON s.ParentID = p.ParentID " +
                        "JOIN Classes c ON s.ClassID = c.ClassID " +
                        "WHERE s.FirstName = @FirstName AND s.LastName = @LastName";
                    break;
                case "Parent":
                    query = "SELECT * FROM Parents WHERE FirstName = @FirstName AND LastName = @LastName";
                    break;
                case "Teacher":
                    query = "SELECT * FROM Teachers WHERE FirstName = @FirstName AND LastName = @LastName";
                    break;
                default:
                    return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    switch (role)
                    {
                        case "Student":
                            string studentClass = reader["ClassName"].ToString();
                            string parentName = $"{reader["ParentFirstName"]} {reader["ParentLastName"]}";
                            string address = reader["Address"].ToString();
                            string dateOfBirth = (reader["DateOfBirth"].ToString());
                            decimal balance = Convert.ToDecimal(reader["Balance"]);
                            UserSession.Instance.SetStudentInfo(studentClass, parentName, address, dateOfBirth,
                                balance);
                            break;
                        case "Parent":
                            string phoneNumber = reader["PhoneNumber"].ToString();
                            string occupation = reader["Occupation"].ToString();
                            UserSession.Instance.SetParentInfo(phoneNumber, occupation);
                            break;
                        case "Teacher":
                            string subject = reader["Subject"].ToString();
                            string teacherPhoneNumber = reader["PhoneNumber"].ToString();
                            UserSession.Instance.SetTeacherInfo(subject, teacherPhoneNumber);
                            break;
                    }
                }
            }
        }
        //Admin
        // Teacher
        // Student
        // Parent
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.FormClosed += (s, args) => this.Show();
            signUpForm.Show();
            this.Hide();
        }

        private void LoadUserInfo(int userId)
        {
            string query = "SELECT * FROM Users WHERE UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    //  object userID = reader["UserId"];
                    string firstName = reader["FirstName"] as string ?? string.Empty;
                    string lastName = reader["LastName"] as string ?? string.Empty;
                    string email = reader["Email"] as string ?? string.Empty;
                    string role = reader["Roles"] as string ?? string.Empty;

                    UserSession.Instance.SetUser(userId, email, role, firstName, lastName);

                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
