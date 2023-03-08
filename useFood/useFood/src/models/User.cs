using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useFood.src.models
{
    internal class User
    {
        private string resName;
        private string email;
        private string password;
        private string location;

        public User(string resName, string email, string password, string location)
        {
            this.resName = resName;
            this.email = email;
            this.password = password;
            this.location = location;
        }
        public string getresName()
        {
            return resName;
        }
        public string getemail()
        {
            return email;
        }
        public string getpassword()
        {
            return password;
        }
        public string getLocation()
        {
            return location;
        }
        public void setresName(string resName)
        {
            this.resName = resName;
        }
        public void setemail(string setemail)
        {
            this.email = setemail;
        }
        public void setpassword(string password)
        {
            this.password = password;
        }
        public void setlocation(string location)
        {
            this.location = location;
        }
    }
  
}
