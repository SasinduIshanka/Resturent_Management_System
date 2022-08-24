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
    public partial class Student_Registration : Form
    {
        public Student_Registration()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
                try
                {

                    string connection = @"Data Source=DESKTOP-2LQAQE4;Initial Catalog=ROTARY;Integrated Security=True";
                    SqlConnection con = new SqlConnection(connection);
                    con.Open();


                    if (txt_stID.Text != "" && txt_stName.Text != "" && txt_add.Text != "" && txt_gen.Text != "")
                    {

                        string sql = @"INSERT INTO student (Student_ID,Student_Name,Address,Gender,TP)
                        VALUES ('" + txt_stID.Text + "','" + txt_stName.Text + "','" + txt_add.Text+ "','" + txt_gen.Text + "','" + txt_TP.Text + "')";


                        SqlCommand command = new SqlCommand(sql, con);
                        command.ExecuteNonQuery();
                        con.Close();


                        MessageBox.Show("Record saved success");
                        



                    }
                    else
                    {
                        MessageBox.Show("please fill all the details correctly");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("failed connect to the database");
                }
            }
    }
}
