namespace SchoolM8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            panel1.Controls.Clear();
            Dashboard dashboard = new Dashboard();
            panel1.Controls.Add(dashboard);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (UserSession.Instance.Role == "Student"||UserSession.Instance.Role == "Admin")
            {
                panel1.Controls.Clear();
                Students students = new Students();
                panel1.Controls.Add(students);
            }
            else
            {
                MessageBox.Show("You do not have permission to access this page.");

            }

        }
        //Admin
        // Teacher
        // Student
        // Parent
        private void btnCanteen_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Canteen canteen = new Canteen();
            panel1.Controls.Add(canteen);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.Role == "Admin")
            {
                panel1.Controls.Clear();
                Admin admin = new Admin();
                panel1.Controls.Add(admin);
            }
            else
            {
                MessageBox.Show("You do not have permission to access this page.");
            }
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string firstName = UserSession.Instance.FirstName;
            string lastName = UserSession.Instance.LastName;
            string role = UserSession.Instance.Role;
            labelFirstName.Text = firstName;
            labelLastName.Text = lastName;
            labelRole.Text = role;
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnAcademicStaff_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.Role == "Teacher"||UserSession.Instance.Role == "Admin")
            {
                panel1.Controls.Clear();
                AcademicStaff academicStaff = new AcademicStaff();
                panel1.Controls.Add(academicStaff);

            }
            else
            {
                MessageBox.Show("You do not have permission to access this page.");
            }
        }

        private void btnParent_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.Role == "Parent"||UserSession.Instance.Role == "Admin")
            {
                panel1.Controls.Clear();
                Parent parent = new Parent();
                panel1.Controls.Add(parent);
            }
            else
            {
                MessageBox.Show("You do not have permission to access this page.");
            }
        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form nextForm = new M8School();
            nextForm.FormClosed += (s, args) => this.Show();
            nextForm.Show();
            this.Hide();
        }
    }
}
