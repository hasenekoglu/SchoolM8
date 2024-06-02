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
            if (UserSession.Instance.Role == "Admin")
            {
                panel5.Controls.Clear();
                AddStudentDetails addStudentDetails = new AddStudentDetails();
                panel5.Controls.Add(addStudentDetails);
            }
            else
            {
                MessageBox.Show("You do not have permission to access this page.");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.Role == "Admin")
            {
                panel5.Controls.Clear();
                AddAcademicStaff addAcademicDetails = new AddAcademicStaff();
                panel5.Controls.Add(addAcademicDetails);
            }
            else
            {
                MessageBox.Show("You do not have permission to access this page.");
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (UserSession.Instance.Role == "Admin")
            {
                panel5.Controls.Clear();
                AddParentDetails addParentDetails = new AddParentDetails();
                panel5.Controls.Add(addParentDetails);
            }
            else
            {
                MessageBox.Show("You do not have permission to access this page.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.Role == "Admin"||UserSession.Instance.Role == "Canteen")
            {
                panel5.Controls.Clear();
                AddCanteenDetails addCanteenDetails = new AddCanteenDetails();
                panel5.Controls.Add(addCanteenDetails);
            }
            else
            {
                MessageBox.Show("You do not have permission to access this page.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.Role == "Admin")
            {
                panel5.Controls.Clear();
                ViewAllReports viewAllReports = new ViewAllReports();
                panel5.Controls.Add(viewAllReports);
            }
            else
            {
                MessageBox.Show("You do not have permission to access this page.");
            }
        }
    }
}
