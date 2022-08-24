using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            Student_Registration SR = new Student_Registration();
            SR.Show();
        }

        private void btn_payments_Click(object sender, EventArgs e)
        {
            Payments p = new Payments();
            p.Show();
        }

        private void btn_view_student_Click(object sender, EventArgs e)
        {
            View_Student v = new View_Student();
            v.Show();
        }
    }
}
