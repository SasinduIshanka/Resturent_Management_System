using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace course_work
{
    public partial class View_Student : Form
    {
        public View_Student()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adpt;
            DataTable dt;

            void display()
            {
                string connection = @"Data Source=DESKTOP-2LQAQE4;Initial Catalog=ROTARY;Integrated Security=True
";
                SqlConnection con = new SqlConnection(connection);
                con.Open();


                adpt = new SqlDataAdapter("select * from student", con);
                dt = new DataTable();
                adpt.Fill(dt);
                data_grid_1.DataSource = dt;
                con.Close();

            }


        }
    }
}
