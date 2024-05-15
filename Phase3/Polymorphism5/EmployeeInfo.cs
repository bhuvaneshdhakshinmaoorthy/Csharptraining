using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism5
{
    public class EmployeeInfo : PersonalInfo
    {
        private int _employeeID = 2000;
        public string EmployeeID { get; set; }
        public override string Name { get; set; }
        public override string FatherName { get; set; }
        public override long MobileNumber { get; set; }
        public override string Gender { get; set; }

        public EmployeeInfo(string name, string fatherName, long mobileNumber, string gender)
        {
            _employeeID++;
            EmployeeID = "EID" + _employeeID;
            Name = name;
            FatherName = fatherName;
            MobileNumber = mobileNumber;
            Gender = gender;
        }
        
        public override string Display()
        {
            return $"{EmployeeID} {Name} {FatherName} {MobileNumber} {Gender} ";
        }
    }
}