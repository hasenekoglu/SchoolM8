using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SchoolM8
{
    public partial class AddStudentDetails : UserControl
    {
        private string connectionString =
                @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public AddStudentDetails()
        {
            InitializeComponent();
        }
        private void AddStudentDetails_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadParents();
            LoadClass();
        }

        private void LoadStudents()
        {
            string query = "SELECT StudentID, FirstName, LastName FROM Students";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string studentName = $"{reader["FirstName"]} {reader["LastName"]}";
                    comboBoxStudents.Items.Add(new ComboBoxItem(studentName, (int)reader["StudentID"]));
                }
            }
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
                    string parentName = $"{reader["FirstName"]} {reader["LastName"]}";
                    comboBoxParents.Items.Add(new ComboBoxItem(parentName, (int)reader["ParentID"]));
                }
            }
        }

        private void LoadClass()
        {
            string query = "SELECT ClassID,ClassName FROM Classes";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string className = $"{reader["ClassName"]}";
                    comboBoxClass.Items.Add(new ComboBoxItem(className, (int)reader["ClassID"]));
                }
            }
        }
        private void LoadStudentDetails(int studentId)
        {
            string query = "SELECT * FROM Students WHERE StudentID = @StudentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", studentId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBoxFirstName.Text = reader["FirstName"]as string ?? string.Empty; ;
                    textBoxLastName.Text = reader["LastName"]as string ?? string.Empty;
                    textBoxDOB.Text = reader["DateOfBirth"]as string ?? string.Empty;
                    //  textBoxBalance.Text = reader["Balance"] as string ?? string.Empty;
                    //dateTimePickerDOB.Value = DateTime.Parse(reader["DateOfBirth"].ToString());
                    textBoxAddress.Text = reader["Address"] as string ?? string.Empty;

                    object parentIdObject = reader["ParentID"];
                    int parentId = parentIdObject != DBNull.Value ? (int)parentIdObject : 0;

                    if (parentId != 0) // ParentID değeri atanmışsa
                    {
                        // ComboBox'ta ParentID'ye sahip öğeyi seç
                        comboBoxParents.SelectedItem = comboBoxParents.Items
                            .OfType<ComboBoxItem>()
                            .FirstOrDefault(i => i.Value == parentId);
                    }
                    else
                    {
                        // ParentID atanmamışsa, comboBoxParents'ı boşalt
                        comboBoxParents.SelectedItem = null;
                    }
                    object classIdObject = reader["ClassID"];
                    int classId = classIdObject != DBNull.Value ? (int)classIdObject : 0;

                    if (classId != 0)
                    {

                        comboBoxClass.SelectedItem = comboBoxClass.Items
                            .OfType<ComboBoxItem>()
                            .FirstOrDefault(i => i.Value == classId);
                    }
                    else
                    {

                        comboBoxClass.SelectedItem = null;
                    }
                    decimal balance = reader["Balance"] != DBNull.Value ? (decimal)reader["Balance"] : 0;
                    textBoxBalance.Text = balance.ToString();
                    // textBoxClassID.Text = reader["ClassID"] as string ?? string.Empty;
                    //textBoxBalance.Text = reader["Balance"] as string ?? string.Empty;
                }
                else
                {
                    textBoxFirstName.Text = string.Empty;
                    textBoxLastName.Text = string.Empty;
                    textBoxDOB.Text = string.Empty;
                    textBoxAddress.Text = string.Empty;
                    comboBoxParents.SelectedItem = null;
                    comboBoxClass.Text = string.Empty;
                    textBoxBalance.Text = string.Empty;
                }
            }
        }
        private void UpdateStudentDetails(int studentId)
        {
            int parentId = 0;
            if (comboBoxParents.SelectedItem != null)
            {
                ComboBoxItem selectedParent = (ComboBoxItem)comboBoxParents.SelectedItem;
                parentId = selectedParent.Value;
            }
            int classId = 0;
            if (comboBoxClass.SelectedItem != null)
            {
                ComboBoxItem selectedClass = (ComboBoxItem)comboBoxClass.SelectedItem;
                classId = selectedClass.Value;
            }
            decimal balance = 0;
            if (!string.IsNullOrWhiteSpace(textBoxBalance.Text))
            {
                balance = decimal.Parse(textBoxBalance.Text);
            }

            string query = "UPDATE Students SET FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth, Address = @Address, ParentID = @ParentID, ClassID = @ClassID, Balance = @Balance WHERE StudentID = @StudentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", studentId);
                command.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                command.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                command.Parameters.AddWithValue("@DateOfBirth", textBoxDOB.Text);
                command.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                command.Parameters.AddWithValue("@ParentID", parentId);
                command.Parameters.AddWithValue("@ClassID", classId);
                command.Parameters.AddWithValue("@Balance", balance);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Student details updated successfully.");
            }
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
            UpdateStudentDetails(studentId);
            panel1.Controls.Clear();
            Admin admin = new Admin();
            panel1.Controls.Add(admin);
        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)comboBoxStudents.SelectedItem;
            int studentId = selectedItem.Value;
            LoadStudentDetails(studentId);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Admin admin = new Admin();
            panel1.Controls.Add(admin);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
