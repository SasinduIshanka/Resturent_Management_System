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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void btn_save_pay_Click(object sender, EventArgs e)
        {
          
                try
                {


                    string connection = @"Data Source=DESKTOP-2LQAQE4;Initial Catalog=ROTARY;Integrated Security=True";

                    SqlConnection con = new SqlConnection(connection);
                    con.Open();


                    if (txt_payment_id.Text != "" && txt_payment_fees.Text != "" && txt_payment_studentID.Text != "" && txt_payment_subject_id.Text != "")
                    {
                        

                        string sql = @"INSERT INTO payment(Payment_ID,Fees,Student_ID,Subject_ID)
                        VALUES ('" + txt_payment_id.Text + "','" + txt_payment_fees.Text + "','" +txt_payment_studentID .Text + "','" + txt_payment_subject_id.Text + "')";


                        SqlCommand command = new SqlCommand(sql, con);
                        command.ExecuteNonQuery();
                        con.Close();


                        MessageBox.Show("Record entered successfully");
                        



                    }
                    else
                    {
                        MessageBox.Show("please details correctly");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("connection fail");
                }
            }
    }
}
