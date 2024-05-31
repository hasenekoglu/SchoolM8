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
    public partial class AcademicStaff : UserControl
    {
        public AcademicStaff()
        {
            InitializeComponent();
        }

        private void AcademicStaff_Load(object sender, EventArgs e)
        {
            LoadTeacherInfo();
        }

        private void LoadTeacherInfo()
        {
            UserSession session = UserSession.Instance;
            labelFirstName.Text = session.FirstName;
            labelLastName.Text = session.LastName;
            labelPhoneNumber.Text = session.PhoneNumber;
            labelEmail.Text = session.Email;
            labelSubject.Text  = session.Subject;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
