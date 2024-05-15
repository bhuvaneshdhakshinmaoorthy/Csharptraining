using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance1
{
    public class StudentInfo : PersonalInfo
    {
        private int _studentID = 2000;
        public string StudentID { get; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }
        public StudentInfo(string name, string fatherName, DateTime dob, long phone, string gender, string mail, string degree, string department, int semester) : base(name, fatherName, dob, phone, gender, mail)
        {
            _studentID++;
            StudentID = "SID" + _studentID;
            Degree = degree;
            Department = department;
            Semester = semester;
        }
        public string ShowDetails()
        {
            return $"StudentID:{StudentID} {Name} {FatherName} {DOB.ToString("dd/MM/yyyy")} {Phone} {Gender} {Mail} {Degree} {Department} {Semester}";
        }
    }
}