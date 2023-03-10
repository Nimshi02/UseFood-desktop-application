using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using useFood.src.dataBase;

namespace useFood.src.view
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Register newRegister = new Register();
            newRegister.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            dbCon newCon = new dbCon();
            newCon.checkPassword(email, password);
            this.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
