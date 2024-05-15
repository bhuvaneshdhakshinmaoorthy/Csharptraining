using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed1
{
    public sealed class EmployeeInfo
    {
        private static int s_userID = 2000;
        public string UserID { get; }
        public string Password { get; set; }
        public int KeyInfo { get{return 100;} }
        public EmployeeInfo(string password)
        {
            s_userID++;
            UserID = "UID" + s_userID;
            Password = password;
        }
        public static void UpdateInfo()
        {

        }
        public string DisplayInfo()
        {
            return Password;
        }
    }
}