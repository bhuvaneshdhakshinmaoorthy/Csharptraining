using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism5
{
    public class SalaryInfo : EmployeeInfo
    {
        private int _numberOfDaysWorked;
        public double NumberOfDaysWorked { get; }
        public SalaryInfo(string name, string fatherName, long mobileNumber, string gender,double numberOfDaysWorked) : base(name, fatherName,  mobileNumber,  gender)
        {
            Name = name;
            FatherName = fatherName;
            MobileNumber = mobileNumber;
            Gender = gender;
            NumberOfDaysWorked = numberOfDaysWorked ;
        }

        public override string Display()
        {
            return $"{Name} {FatherName} {MobileNumber} {Gender} Salary:{NumberOfDaysWorked*500}";
        }
        // public double SalaryCalcula
    }
}