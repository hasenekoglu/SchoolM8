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

            panel1.Controls.Clear();
            Students students = new Students();
            panel1.Controls.Add(students);
        }

        private void btnCanteen_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Canteen canteen = new Canteen();
            panel1.Controls.Add(canteen);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Admin admin = new Admin();
            panel1.Controls.Add(admin);
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnAcademicStaff_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AcademicStaff academicStaff = new AcademicStaff();
            panel1.Controls.Add(academicStaff);
        }

        private void btnParent_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Parent parent = new Parent();
            panel1.Controls.Add(parent);
        }

       
    }
}
