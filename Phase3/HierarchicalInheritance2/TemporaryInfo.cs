using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance2
{
    public class TemporaryInfo : SalaryInfo
    {
        private int _employeeID = 2000;
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public double DA { get{return 0.15  * BasicSalary;} }
        public double HRA { get{return 0.13  * BasicSalary;} }
        public double TotalSalary { get; set; }
        public TemporaryInfo(double basicSalary, string month, string employeeType) : base(basicSalary, month)
        {
            _employeeID++;
            EmployeeID = "EID" + _employeeID;
            EmployeeType = employeeType;
            // TotalSalary =  totalSalary;
        }

        public double CalculateTotalSalary()
        {
            TotalSalary =  BasicSalary + DA + HRA;
            return TotalSalary;
        }

        public double ShowSalary()
        {
            return CalculateTotalSalary();
        }
    }
}