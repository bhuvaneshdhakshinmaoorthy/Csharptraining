using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism7
{
    public class Attendance
    {
        public int TotalWorkingDays { get; set; }
        public int NumberOfLeaves { get; set; }
        public double NumberOfPermission { get; set; }
        public Attendance(int totalWorkingDays, int numberOfLeaves, double numberOfPermission)
        {
            TotalWorkingDays = totalWorkingDays;
            NumberOfLeaves = numberOfLeaves;
            NumberOfPermission = numberOfPermission;
        }
        public double Salary()
        {
            double salaryCalculation;
            if (NumberOfPermission <= 3)
            {
                return salaryCalculation = (TotalWorkingDays - NumberOfLeaves) * 500;
            }
            else
            {
                return salaryCalculation = (TotalWorkingDays - NumberOfLeaves-1) * 500;
            }

        }
    }
}