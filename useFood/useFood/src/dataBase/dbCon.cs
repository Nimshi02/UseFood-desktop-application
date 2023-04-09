using Google.Cloud.Firestore;
using Google.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using useFood.src.models;
using useFood.src.view;

namespace useFood.src.dataBase
{
    internal class dbCon
    {
        User newUser;
        FirestoreDb db;
        public static string UserId="";
        public static string resAddress = "";
        public static string username = "";
        public dbCon()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"service.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("newproject-4e93c");

            
        }
        public void addUser(User newUser)
        {
            this.newUser = newUser;
            CollectionReference col = db.Collection("ResUser");
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"email",newUser.getemail()},
                {"resName",newUser.getresName()},
                {"Location",newUser.getLocation()},
                {"password",newUser.getpassword() }
            };
            col.AddAsync(data);
            MessageBox.Show("User added successfully");

        }
        public void addDonation(string name, string qty,string date,string location,string type,string Donorname,string no,string image)
        {
            CollectionReference col = db.Collection("donations");
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"Expiredate",date},
                {"ItemImage",image},
                {"ItemName",name},
                {"Location",location },
                {"PostDate",System.DateTime.Now.ToString() },
                {"Qty",qty },
                {"Type",type },
                {"ContactDetails",no },
                {"owner",Donorname },
                {"userId",UserId }
            };
            col.AddAsync(data);
            MessageBox.Show("Donation added successfully");
        }

        public void addDiscount(string IName, string valid, string desc, string rate, string type, string Iimage)
        {
            CollectionReference col = db.Collection("FoodDeals");
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                
                {"ItemImage",Iimage},
                {"ItemName",IName},
                {"PostDate",System.DateTime.Now.ToString() },
                {"Type",type },
                {"ValidDate",valid },
                {"description",desc },
                 {"discountRate",rate},
                {"resAddress",resAddress },
                {"resId",UserId },
                {"resName",username }
               
            };
            col.AddAsync(data);
            MessageBox.Show("Discount added successfully");
        }
        public async void checkPassword(string email,string password)
        {

            CollectionReference colRef = db.Collection("ResUser");
            Query query = colRef.WhereEqualTo("email", email);
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
            if (querySnapshot.Documents.Count>0)
            {
                DocumentSnapshot docSnap = querySnapshot.Documents[0];
                Dictionary<string, object> user = docSnap.ToDictionary();
                if (user["password"].ToString() == password)
                {
                    MessageBox.Show("User is authenticated");
                    UserId= docSnap.Id;
                    resAddress = user["Location"].ToString();
                        username=user["resName"].ToString();

                    Home newHome = new Home();
                    newHome.Show();
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
