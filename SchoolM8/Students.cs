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
    public partial class Students : UserControl
    {
        public Students()
        {
            InitializeComponent();
        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CafeteriaForm cafeteriaForm = new CafeteriaForm();
            panel1.Controls.Add(cafeteriaForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            StudentAttendance studentAttendance = new StudentAttendance();
            panel1.Controls.Add(studentAttendance);
        }





        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void Students_Load(object sender, EventArgs e)
        {
            LoadStudentInfo();
        }

        private void LoadStudentInfo()
        {
            UserSession session = UserSession.Instance;

            labelFirstName.Text = session.FirstName;
            labelLastName.Text = session.LastName;
            labelEmail.Text = session.Email;
            labelAddress.Text = session.Address;
            labelBalance.Text = session.Balance.ToString("C");
            labelParentName.Text=session.ParentName;
            labelDOB.Text = session.DateOfBirth;
            labelClass.Text = session.StudentClass;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
