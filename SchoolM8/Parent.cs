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

        private SqlConnection connect = new SqlConnection(@"Data Source=HASENEK;Initial Catalog=SchoolM8DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");



        private void Parent_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
