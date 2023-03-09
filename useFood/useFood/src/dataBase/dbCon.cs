using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using useFood.src.models;

namespace useFood.src.dataBase
{
    internal class dbCon
    {
        User newUser;
        FirestoreDb db;
        public dbCon()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"service.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("newproject-4e93c");

            
        }
        public void addUser(User newUser)
        {
            this.newUser = newUser;
            DocumentReference col = db.Collection("ResUser").Document(newUser.getemail());
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"email",newUser.getemail()},
                {"resName",newUser.getresName()},
                {"Location",newUser.getLocation()},
                {"password",newUser.getpassword() }
            };
            col.SetAsync(data);
            MessageBox.Show("User added successfully");

        }
        public async void checkPassword(string email,string password)
        {

            DocumentReference docref = db.Collection("ResUser").Document(email);
            DocumentSnapshot snap=await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                Dictionary<string, object> user = snap.ToDictionary();
                if (user["password"].ToString() == password)
                {
                    MessageBox.Show("User is authenticated");
                }
                else
                {
                    MessageBox.Show("User is not authenticated");
                }
            }
            else
            {
                MessageBox.Show("No msg");
            }

        }

    }
}
