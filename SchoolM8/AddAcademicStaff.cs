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
    public partial class AddAcademicStaff : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public AddAcademicStaff()
        {
            InitializeComponent();
        }

        private void AddAcademicStaff_Load(object sender, EventArgs e)
        {
            LoadTeacher();
        }
        private void LoadTeacher()
        {
            string query = "SELECT TeacherID, FirstName, LastName FROM Teachers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string teacherName = $"{reader["FirstName"]} {reader["LastName"]}";
                    object teacherIdObject = reader["TeacherID"];
                    int teacherId = teacherIdObject != DBNull.Value ? (int)teacherIdObject : 0;
                    comboBoxStudents.Items.Add(new ComboBoxItem(teacherName, teacherId));
                }
            }
        }

        private void LoadTeacherDetails(int teacherId)
        {
            string query = "SELECT * FROM Teachers WHERE TeacherID = @TeacherID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeacherID", teacherId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBoxFirstName.Text = reader["FirstName"]as string ?? string.Empty; ;
                    textBoxLastName.Text = reader["LastName"]as string ?? string.Empty;
                    textBoxSubject.Text = reader["Subject"]as string ?? string.Empty; ;
                    textBoxPhoneNum.Text = reader["PhoneNumber"]as string ?? string.Empty;
                }
                else
                {
                    textBoxFirstName.Text = string.Empty;
                    textBoxLastName.Text = string.Empty;
                    textBoxPhoneNum.Text = string.Empty;
                    textBoxSubject.Text = string.Empty;

                }
            }
        }

        private void UpdateTeacherDetails(int teacherId)
        {
            string query = "UPDATE Teachers SET FirstName = @FirstName, LastName = @LastName, Subject = @Subject, PhoneNumber = @PhoneNumber WHERE TeacherID = @TeacherID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeacherID", teacherId);
                command.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                command.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                command.Parameters.AddWithValue("@Subject", textBoxSubject.Text);
                command.Parameters.AddWithValue("@PhoneNumber", textBoxPhoneNum.Text);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Teacher details updated successfully");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)comboBoxStudents.SelectedItem;
            int teacherId = selectedItem.Value;
            LoadTeacherDetails(teacherId);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Admin admin = new Admin();
            panel1.Controls.Add(admin);
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
            int studentId = selectedItem.Value;
            UpdateTeacherDetails(studentId);
            panel1.Controls.Clear();
            Admin admin = new Admin();
            panel1.Controls.Add(admin);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            EditClasses editClasses = new EditClasses();
            panel1.Controls.Add(editClasses);
        }
    }

}