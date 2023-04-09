using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using useFood.src.dataBase;

namespace useFood.src.view
{
    public partial class Home : Form
    {
        public string FianlUrl = "";
        public string FinalDisUrl = "";
        public Home()
        {
            InitializeComponent();
            panel_signOut.Visible = true;
            panel_addDiscount.Visible = false;
            panel2.Visible = false;
            panel10.Visible=false;
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_discount.Visible = true;
            panel_addDiscount.Visible=true;
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
            panel2.Visible = false;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_donation2.Visible = true;
            panel10.Visible = true;
            panel_home.Visible = false;
            panel_addDiscount.Visible=false;
            panel_signOut.Visible = false;
            panel2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"service.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            // Initialize a connection to your Firebase project's Storage bucket
            var storage = StorageClient.Create();
            var bucketName = "newproject-4e93c.appspot.com";

            // Open a file dialog to select the file to upload
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*png)|*.phg";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string imagePath = dialog.FileName;

                // Set the name of the file in Firebase Storage
                string storagePath = "photos/";
                string filename = Path.GetFileName(imagePath);
                string storageObjectName = $"{storagePath}{filename}";

                // Upload the file to Firebase Storage
                using (var stream = new FileStream(imagePath, FileMode.Open))
                {
                    var result = storage.UploadObject(bucketName, storageObjectName, null, stream);
                    String firebaseStorageUrl = result.MediaLink;
                    this.FianlUrl = firebaseStorageUrl;
                    MessageBox.Show(FianlUrl);
                }
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string name=txtName.Text;
            string qty=txtQty.Text;
            string date=txtDate.Text;
            string location=txtLocation.Text;
            string type=txtFoodType.Text;
            string donorName=txtDonor.Text;
            string contactNo=txtContact.Text;
            string image = FianlUrl;
            dbCon newdb = new dbCon();
            newdb.addDonation(name,qty,date,location,type, donorName,contactNo,image);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"service.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            // Initialize a connection to your Firebase project's Storage bucket
            var storage = StorageClient.Create();
            var bucketName = "newproject-4e93c.appspot.com";

            // Open a file dialog to select the file to upload
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*png)|*.phg";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string imagePath = dialog.FileName;

                // Set the name of the file in Firebase Storage
                string storagePath = "photos/";
                string filename = Path.GetFileName(imagePath);
                string storageObjectName = $"{storagePath}{filename}";

                // Upload the file to Firebase Storage
                using (var stream = new FileStream(imagePath, FileMode.Open))
                {
                    var result = storage.UploadObject(bucketName, storageObjectName, null, stream);
                    String firebaseStorageUrl = result.MediaLink;
                    this.FinalDisUrl = firebaseStorageUrl;
                    MessageBox.Show(FinalDisUrl);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string IName = txtIName.Text;
            string validTill=txtValid.Text;
            string desc=txtDesc.Text;
            string rate=txtRate.Text;
            string type=txtType.Text;
            string Iimage = FinalDisUrl;
            dbCon newcon = new dbCon();
            newcon.addDiscount(IName,validTill, desc, rate, type,Iimage);
    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_home.Visible = true;
            panel_signOut.Visible = true;
            panel_addDiscount.Visible = false;
            panel2.Visible = false;
            label4.Visible =true;
            panel10.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel2.Visible=true;
            Login newLogin = new Login();
            newLogin.Show();
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Maximized;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
