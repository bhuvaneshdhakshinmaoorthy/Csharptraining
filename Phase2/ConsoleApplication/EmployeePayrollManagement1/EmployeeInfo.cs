using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayrollManagement1
{
    public enum WorkLocation{Select,AnnaNagar,Kilpauk}
    public enum Gender{Select,Male,Female,Others}
    public class EmployeeInfo
    {
        private static int s_employeID = 1000;
        public String  EmployeID { get; }
        public string EmployeName { get; set; }
        public string Role { get; set; }
        public WorkLocation WorkLocation { get; set; }
        public string TeamName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int NoOfWorkingDaysInMonth { get; set; }
        public int NoOfLeaveTaken { get; set; }
        public Gender Gender { get; set; }

        public EmployeeInfo(string employeName,string role,WorkLocation workLocation,string teamName,DateTime dateOfJoining,int noOfWorkingDaysInMonth,int noOfLeaveTaken,Gender gender)
        {
            s_employeID++;
            EmployeID = "SF" + s_employeID;
            EmployeName = employeName;
            Role = role;
            WorkLocation = workLocation;
            TeamName = teamName;
            DateOfJoining = dateOfJoining;
            NoOfWorkingDaysInMonth = noOfWorkingDaysInMonth;
            NoOfLeaveTaken = noOfLeaveTaken;
            Gender = gender;
        }
        public int SalaryCalculation()
        {
            return(NoOfWorkingDaysInMonth-NoOfLeaveTaken)*500;
        }
    }
}