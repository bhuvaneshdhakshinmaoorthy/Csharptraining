using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed3
{
    public class EmployeeInfo : PersonalInfo
    {
        private int _employeeID = 3000;
        public string EmployeeID { get; set; }
        public DateTime DateOfJoining { get; set; }
        public EmployeeInfo(DateTime dateOfJoining)
        {
            _employeeID++;
            EmployeeID = "EID" + _employeeID;
            DateOfJoining = dateOfJoining;
        }
    }
}