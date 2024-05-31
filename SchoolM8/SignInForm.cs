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
    public partial class M8School : Form
    {
        public M8School()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void M8School_Load(object sender, EventArgs e)
        {

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
                    new SqlCommand("SELECT UserID, Roles FROM Users WHERE Email = @Email AND Password = @Password",
                        connect);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int userId = (int)reader["UserId"];
                    string role = reader["Roles"].ToString();

                    // Save the user details in the UserSession singleton
                    UserSession.Instance.SetUser(userId, email, role);

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
    }
}
