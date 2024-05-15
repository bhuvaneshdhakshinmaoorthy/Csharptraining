using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance1
{
    public class TeacherInfo : PersonalInfo
    {
        private int _teacherID = 2000;
        public string TeacherID { get; }
        public string Department { get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public double YearsOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        public TeacherInfo(string name, string fatherName, DateTime dob, long phone, string gender, string mail, string department, string subjectTeaching, string qualification, double yearsOfExperience, DateTime dateOfJoining) : base(name, fatherName, dob, phone, gender, mail)
        {
            _teacherID++;
            TeacherID = "TID" + _teacherID;
            Department = department;
            SubjectTeaching = subjectTeaching;
            Qualification = qualification;
            YearsOfExperience = yearsOfExperience;
            DateOfJoining = dateOfJoining;
        }
        public string ShowDetails()
        {
            return $"TeacherID:{TeacherID} {Name} {FatherName} {DOB.ToString("dd/MM/yyyy")} {Phone} {Gender} {Mail} {Department} {SubjectTeaching} {Qualification} {YearsOfExperience} DOJ:{DateOfJoining.ToString("dd/MM/yyyy")}";
        }
    }
} 