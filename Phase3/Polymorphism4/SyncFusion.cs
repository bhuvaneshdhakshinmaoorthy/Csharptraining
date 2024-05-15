using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism4
{
    public class SyncFusion : FreeLancer
    {
        private int _employeeID = 1000;
        public string EmployeeID { get; set; }
        public string WorkLocation { get; set; }
        public SyncFusion(string name, string fatherName, string gender, string qualification, string role, int noOfWorkingDays, string workLocation) : base(name, fatherName, gender, qualification, role, noOfWorkingDays)
        {
            _employeeID++;
            EmployeeID = "EID" + _employeeID;
            WorkLocation = workLocation;
        }
        public override double CalculateSalary()
        {
            return base.CalculateSalary();
        }
        public new virtual string Display()
        {
            return $"{EmployeeID} {Name} {FatherName} {Gender} {Qualification} {Role} {CalculateSalary()} {NoOfWorkingDays} {WorkLocation}";
        }
    }
}