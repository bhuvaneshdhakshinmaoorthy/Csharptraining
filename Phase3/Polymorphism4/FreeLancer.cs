using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism4
{
    public class FreeLancer : PersonalDetails
    {
        public string Role { get; set; }
        public double SalaryAmount { get; set; }
        public int NoOfWorkingDays { get; set; }
        public FreeLancer(string name, string fatherName, string gender, string qualification, string role, int noOfWorkingDays) : base(name, fatherName, gender, qualification)
        {
            Role = role;
            // SalaryAmount = salaryAmount;
            NoOfWorkingDays = noOfWorkingDays;
        }

        public virtual double CalculateSalary()
        {
            return SalaryAmount = NoOfWorkingDays * 500;
        }
        public virtual string Display()
        {
            return $"{Name} {FatherName} {Gender} {Qualification} {Role} {CalculateSalary()} {NoOfWorkingDays}";
        }
    }
}