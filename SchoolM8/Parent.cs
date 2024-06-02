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
    public partial class Parent : UserControl
    {
        public Parent()
        {
            InitializeComponent();
        }

        private SqlConnection connect =
            new SqlConnection
                (@"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");



        private void Parent_Load(object sender, EventArgs e)
        {
            LoadParentInfo();
        }

        private void LoadParentInfo()
        {
            UserSession session = UserSession.Instance;
            lbFirstName.Text = session.FirstName;
            lbLastName.Text = session.LastName;
            lbEmail.Text = session.Email;
            lbPhoneNumber.Text = session.PhoneNumber;
            lbOccupation.Text = session.Occupation;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddBalance addBalance = new AddBalance();
            panel1.Controls.Add(addBalance);
        }

        private void lbFirstName_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ViewStudent viewStudent = new ViewStudent();
            panel1.Controls.Add(viewStudent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Restrict restrict = new Restrict();
            panel1.Controls.Add(restrict);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PurchaseHistory purchaseHistory = new PurchaseHistory();
            panel1.Controls.Add(purchaseHistory);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AttendanceViewer attendanceViewer = new AttendanceViewer();
            panel1.Controls.Add(attendanceViewer);
        }
    }
}
