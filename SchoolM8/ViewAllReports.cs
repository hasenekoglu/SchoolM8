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
    public partial class ViewAllReports : UserControl
    {
        public ViewAllReports()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ViewStudents viewStudents = new ViewStudents();
            panel1.Controls.Add(viewStudents);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ViewAttendance viewStudents = new ViewAttendance();
            panel1.Controls.Add(viewStudents);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ViewCafeteriaPurchases viewStudents = new ViewCafeteriaPurchases();
            panel1.Controls.Add(viewStudents);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ViewParents viewStudents = new ViewParents();
            panel1.Controls.Add(viewStudents);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ViewItemRestrictions viewStudents = new ViewItemRestrictions();
            panel1.Controls.Add(viewStudents);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ViewTeachers viewStudents = new ViewTeachers();
            panel1.Controls.Add(viewStudents);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ViewClasses viewStudents = new ViewClasses();
            panel1.Controls.Add(viewStudents);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ViewUsers viewStudents = new ViewUsers();
            panel1.Controls.Add(viewStudents);
        }
    }
}
