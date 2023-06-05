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
    public partial class asus : Form
    {
        public asus()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        string sqllink = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aliba\source\repos\computer_pro\computer_pro\db_lopto.mdf;Integrated Security=True";

        void ASUS()
        {
            cn = new SqlConnection(sqllink);
            da = new SqlDataAdapter("select *from tb_asus", cn);
            ds = new DataSet();
            cn.Open();
            da.Fill(ds, "tb_asus");


            dataGridView1.DataSource = ds.Tables["tb_asus"];
            cn.Close();

        }
        private void asus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_loptoDataSet.tb_asus' table. You can move, or remove it, as needed.
            this.tb_asusTableAdapter.Fill(this.db_loptoDataSet.tb_asus);
            ASUS();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            ob.ShowDialog();
        }
         
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            homepage na = new homepage();
            this.Hide();
            na.ShowDialog();    
        }
    }
}
