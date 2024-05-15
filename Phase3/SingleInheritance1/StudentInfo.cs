using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance1
{
    public class StudentInfo  : PersonalInfo
    {
        public int RegisterNumber { get; set; }
        public int Standard { get; set; }
        public string Branch { get; set; }
        public string AcademicYear { get; set; }
        public  StudentInfo(string name, string fatherName, long phone, string mail, DateTime dob, string gender, int registerNumber, int standard, string branch, string academicYear):base( name,  fatherName,  phone,  mail,  dob,  gender)
        {
            RegisterNumber = registerNumber;
            Standard = standard;
            Branch = branch;
            AcademicYear = academicYear;
        }
        public string ShowStudentInfo()
        {
            return ($"{Name} {FatherName} {Phone} {Mail} {DOB.ToString("dd/MM/yyyy")} {Gender} {RegisterNumber} {Standard} {Branch} {AcademicYear}");
        }
    }
}