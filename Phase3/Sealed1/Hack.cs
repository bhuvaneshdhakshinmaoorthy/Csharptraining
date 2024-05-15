using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed1
{
    public class Hack : EmployeeInfo
    {
        public string StoreUserID { get; set; }
        public string StorePassword { get; set; }
        public int ShowKeyInfo()
        {
            return KeyInfo;
        }
        public void GetUserInfo()
        {
            
        }
        public void ShowUserInfo()
        {
            
        }
    }
}