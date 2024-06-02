using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace SchoolM8
{
    public partial class EditClasses : UserControl
    {
        private string connectionString =
            @"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public EditClasses()
        {
            InitializeComponent();
        }

        private void EditClasses_Load(object sender, EventArgs e)
        {
            LoadTeachers(); // Öğretmenleri yükle
            LoadClasses(); // Sınıfları yükle
        }

        private void LoadTeachers()
        {
            // Öğretmenleri veritabanından yükle
            string query = "SELECT TeacherID, FirstName, LastName FROM Teachers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string teacherName = $"{reader["FirstName"]} {reader["LastName"]}";
                    int teacherId = Convert.ToInt32(reader["TeacherID"]);
                    comboBoxTeachers.Items.Add(new ComboBoxItem(teacherName, teacherId));
                }
            }
        }

        private void LoadClasses()
        {
            // Sınıfları veritabanından yükle
            string query = "SELECT ClassID, ClassName FROM Classes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string className = reader["ClassName"].ToString();
                    int classId = Convert.ToInt32(reader["ClassID"]);
                    comboBoxClasses.Items.Add(new ComboBoxItem(className, classId));
                }
            }
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {

        }

        private void buttonAssignTeacher_Click(object sender, EventArgs e)
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

        private void buttonAddClass_Click_1(object sender, EventArgs e)
        {
            string className = textBoxClassName.Text;

            // Veritabanına yeni sınıf ekleme sorgusu
            string query = "INSERT INTO Classes (ClassName) VALUES (@ClassName)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClassName", className);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("New class added successfully.");
                    comboBoxClasses.Items.Clear(); // Yeni sınıf ekledikten sonra listeyi güncelle
                    LoadClasses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding new class: " + ex.Message);
                }
            }
        }

        private void buttonAssignTeacher_Click_1(object sender, EventArgs e)
        {
            // Seçilen sınıfın ve öğretmenin ID'sini alın
            ComboBoxItem selectedClass = (ComboBoxItem)comboBoxClasses.SelectedItem;
            int classId = selectedClass.Value;

            ComboBoxItem selectedTeacher = (ComboBoxItem)comboBoxTeachers.SelectedItem;
            int teacherId = selectedTeacher.Value;

            // Veritabanında ilgili sınıfın öğretmen ID'sini güncelleme sorgusu
            string query = "UPDATE Classes SET TeacherID = @TeacherID WHERE ClassID = @ClassID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeacherID", teacherId);
                command.Parameters.AddWithValue("@ClassID", classId);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Teacher assigned to class successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error assigning teacher to class: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddAcademicStaff addAcademicStaff = new AddAcademicStaff();
            panel1.Controls.Add(addAcademicStaff);
        }

        private void buttonDeleteClass_Click(object sender, EventArgs e)
        {
            // Seçilen sınıfın ID'sini alın
            ComboBoxItem selectedClass = (ComboBoxItem)comboBoxClasses.SelectedItem;
            int classId = selectedClass.Value;

            // Veritabanından ilgili sınıfı silme sorgusu
            string query = "DELETE FROM Classes WHERE ClassID = @ClassID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClassID", classId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Class deleted successfully.");
                        comboBoxClasses.Items.Clear(); // Sınıfı sildikten sonra listeyi güncelle
                        LoadClasses();
                    }
                    else
                    {
                        MessageBox.Show("Class not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting class: " + ex.Message);
                }
            }
        }
    }
}
