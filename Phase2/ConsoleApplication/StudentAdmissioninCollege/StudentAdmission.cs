using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmissioninCollege
{
    public enum Gender {Selct, Male, Female, Transgender}
    public class StudentAdmission
    {
        private static int s_studentID = 3002;
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public int MyProperty { get; set; }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Maths { get; set; }

        public StudentAdmission(string studentName, string fatherName, DateTime dob, Gender gender, double physics, double chemistry, double maths)
        {
            s_studentID++;
            StudentID = "SF" + s_studentID;
            StudentName = studentName;
            FatherName = fatherName;
            DOB = dob;
            Gender = gender;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }


        ~StudentAdmission()
        {       
        }
    }
}