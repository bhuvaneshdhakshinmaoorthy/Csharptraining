using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface2
{
    public class EmployeeInfo : IDisplayInfo
    {
        private int _employeeID = 2000;
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }

        public EmployeeInfo(string name, string fatherName)
        {
            _employeeID++;
            EmployeeID = "EID" + _employeeID;
            Name = name;
            FatherName = fatherName;
        }
        public string Display()
        {
            return $"{EmployeeID} {Name} {FatherName}";
        }
    }
}