using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance2
{
    public class PermanentEmployee : SalaryInfo
    {
        private int _employeeID = 1000;
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public double DA { get{return 0.2  * BasicSalary;} }
        public double HRA { get{return 0.18  * BasicSalary;} }
        public double PF { get{return 0.1 * BasicSalary;} }
        public double TotalSalary { get; set; }
        public PermanentEmployee(double basicSalary, string month, string employeeType) : base(basicSalary, month)
        {
            _employeeID++;
            EmployeeID = "EID" + _employeeID;
            EmployeeType = employeeType;
            // TotalSalary =  totalSalary;
        }

        public double CalculateTotalSalary()
        {
            TotalSalary =  BasicSalary + DA + HRA - PF;
            return TotalSalary;
        }

        public double ShowSalary()
        {
            return CalculateTotalSalary();
        }

    }
}