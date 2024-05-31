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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //if (UserSession.Instance.Role != "Teacher")
            //{
            //    MessageBox.Show("You do not have permission to access this page.");
                
            //    return;
            //}
            //Form1 form = new Form1();
            //form.Show();
        }
    }
}
