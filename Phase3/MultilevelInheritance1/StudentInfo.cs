using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance1
{
    public class StudentInfo  : PersonalInfo
    {
        private int _studentRN = 1000; 
        public string RegisterNumber { get; set; }
        public int Standard { get; set; }
        public string Branch { get; set; }
        public string AcademicYear { get; set; }
        public  StudentInfo(string name, string fatherName, long phone, string mail, DateTime dob, string gender, int standard, string branch, string academicYear):base( name,  fatherName,  phone,  mail,  dob,  gender)
        {
            _studentRN++;
            RegisterNumber = "SRN" + _studentRN;
            Standard = standard;
            Branch = branch;
            AcademicYear = academicYear;
        }
        public void GetStudentInfo()
        {

        }
        public string ShowStudentInfo()
        {
            return $"{RegisterNumber} {Name} {FatherName} {Phone} {Mail} {DOB.ToString("dd/MM/yyyy")} {Gender} {Standard} {Branch} {AcademicYear}";
        }
    }
}