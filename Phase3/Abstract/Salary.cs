using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Salary
    {
        // Partial Abstraction
        // Never Static
        // Field maybe
        // No Constructor
        // Normal and Abstract prop available
        // can be used only with heritance
        // Normal and Abstract Method available
        // Cannot create Object for this

        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public abstract string CompanyeName { get; set; }
        public double TotalSalary { get; set; }
        public abstract void CalculateSalry(int days, double salaryPerday);
    }
}