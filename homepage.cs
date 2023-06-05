using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer_pro
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          //  hp ob = new hp();
         //   this.Hide();
          //  ob.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          //  mac ob = new mac();
          //  this.Hide();
         //   ob.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            asus ob = new asus();
            this.Hide();
            ob.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1(); 
            this.Close();
            ob.ShowDialog(); 
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
