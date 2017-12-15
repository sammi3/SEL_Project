using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering_Project
{
    class Login
    {
        public string username { get; set;}
        public string password { get; set; }

        public Login(string username, string pass)
        {
            this.username = username;
            this.password = pass;
        }

        public bool checkLogin()
        {
            //This method calls to the DBConnection instance method userexists using the username and password
            bool test;
            test = DBConnection.getDBConnectionInstance().userExists(username, password);
            if (test) return true;
            else return false;
        }
    }
}
