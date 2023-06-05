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

namespace computer_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abdal\OneDrive\Desktop\‏‏dayana_45\dayana_45\computer_pro\db_lopto.mdf;Integrated Security=True");

                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                String cmd = "SELECT count(*) from login where usr='" + id1.Text + "' and pass= '" + id2.Text + "'";

                SqlCommand cd = new SqlCommand(cmd, cn);
                int r = Convert.ToInt32(cd.ExecuteScalar());


                if (r > 0)
                {
                    
                    homepage fr = new homepage();
                    fr.Show();
                    this.Hide();
                    
                }

                else
                    MessageBox.Show("اسم المستخدم او كلمة السر غير صحيحة ");

                if (cn.State == ConnectionState.Open)
                    cn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void id1_TextChanged(object sender, EventArgs e)
        {

        }

        private void id2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
} 
