using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance1
{
    public class PrincipalInfo : PersonalInfo
    {
        private int _principalID = 2000;
        public string PrincipalID { get; }
        public string Qualification { get; set; }
        public double YearsOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        public PrincipalInfo(string name, string fatherName, DateTime dob, long phone, string gender, string mail,string qualification, double yearsOfExperience, DateTime dateOfJoining ) : base(name, fatherName, dob, phone, gender, mail)
        {
            _principalID++;
            PrincipalID = "PID" + _principalID;
            Qualification = Qualification;
            YearsOfExperience = YearsOfExperience;
            DateOfJoining = dateOfJoining;
        }
        public string ShowDetails()
        {
            return $"StudentID:{PrincipalID} {Name} {FatherName} {DOB.ToString("dd/MM/yyyy")} {Phone} {Gender} {Mail} {Qualification} {YearsOfExperience} DOJ:{DateOfJoining.ToString("dd/MM/yyyy")}";
        }
    }
}