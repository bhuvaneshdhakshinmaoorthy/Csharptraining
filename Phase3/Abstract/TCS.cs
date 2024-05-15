using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract
{
    public class TCS : Salary
    {
        public override string CompanyeName { get; set; }

        public TCS(string employeeID, string employeeName,string createompanyeName)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName ;
            CompanyeName = CompanyeName;
        }

        public override void CalculateSalry(int days, double salaryPerday)
        {
            double salary = days * salaryPerday;
            TotalSalary = 0.18*salary + salary;
        }
    }
}