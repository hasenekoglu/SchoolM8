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
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            AddStudentDetails addStudentDetails = new AddStudentDetails();
            panel5.Controls.Add(addStudentDetails);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            AddAcademicStaff addAcademicDetails = new AddAcademicStaff();
            panel5.Controls.Add(addAcademicDetails);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            AddParentDetails addParentDetails = new AddParentDetails();
            panel5.Controls.Add(addParentDetails);
        }
    }
}
