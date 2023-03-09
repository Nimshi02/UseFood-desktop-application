using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using useFood.src.dataBase;
using useFood.src.models;
using useFood.src.view;

namespace useFood
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string resName = txtResName.Text;
            string location=txtLocation.Text;
            string password = txtPassword.Text;
            string cPassword=txtCPassword.Text;
            if(password==cPassword)
            {
                User newUser = new User(resName,email,password,location);
                dbCon newDb = new dbCon();
                newDb.addUser(newUser);
            }

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login newLogin = new Login();
            newLogin.Show();
            this.Hide();

        }
    }
}
