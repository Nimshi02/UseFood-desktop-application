using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace useFood.src.view
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_discount.Visible = true;
            panel_home.Visible = false;
            panel10.Visible = false;
            panel_signOut.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_discount.Visible = true;
            panel10.Visible = true;
            label4.Visible = false;
            panel_addDiscount.Visible = true;
            panel_signOut.Visible = false;
            panel_donation2.Visible = false;
            panel_home.Visible = false;
            panel10.Visible = false; 
            panel_signOut.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
         
        private void button3_Click(object sender, EventArgs e)
        {
            panel_discount.Visible = false;
            panel_home.Visible = false;
            panel10.Visible = true;
            panel_donation2.Visible = true;
            panel_addDiscount.Visible = false;
            panel_signOut.Visible = false;
            panel_body.Visible = true;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_discount.Visible = true;
            panel_home.Visible = false;
            panel_addDiscount.Visible=false;
            panel_signOut.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*png)|*.phg";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                    imageLocation = dialog.FileName;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error Occured");
            }
        }
    }
}
