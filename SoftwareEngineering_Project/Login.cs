using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering_Project
{
    class Login
    {
        public string staffID { get; set;}
        public string staffPassword { get; set; }

        public Login(string staffID, string pass)
        {
            this.staffID = staffID;
            this.staffPassword = pass;
        }

        public bool checkLogin()
        {
            if ((staffID == "0001") && (staffPassword == "password")) return true;
            else return false;
        }
    }
}
