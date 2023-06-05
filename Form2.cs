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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection cn;
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abdal\OneDrive\Desktop\‏‏dayana_45\dayana_45\computer_pro\db_lopto.mdf;Integrated Security=True");

            string add = " insert into tb_buy (Name,Adres,Orde,marka,Email,Phone) values ('" + t1.Text + "', '" + t2.Text + "' , '" + t3.Text + "','" + t4.Text + "' ,'" + t5.Text+ "','" + t6.Text + "')";

            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@Name", t1.Text);
            cmd.Parameters.AddWithValue("@Adres", t2.Text);
            cmd.Parameters.AddWithValue("@Orde", t3.Text);
            cmd.Parameters.AddWithValue("@marka", t4.Text);
            cmd.Parameters.AddWithValue("@Email", t5.Text);
            cmd.Parameters.AddWithValue("@Phone", t6.Text);
         

            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = add;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Your request has been added... ");
            cn.Close();
            Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
