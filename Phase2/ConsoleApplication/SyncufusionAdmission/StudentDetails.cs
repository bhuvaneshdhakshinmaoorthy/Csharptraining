using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncufusionAdmission
{
    public enum Gender { Select, Male, Female, Transgender }
    public class StudentDetails
    {
        private static int s_studentID = 3000;
        public string StudentID { get; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Maths { get; set; }

        public StudentDetails(string studentName, string fatherName, DateTime dob, Gender gender, double physics, double chemistry, double maths)
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

        public bool IsEligible(double cutoff)
        {
            double average = (Physics + Chemistry + Maths) / 3;

            if (average >= cutoff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public StudentDetails(string student)
        {
            string[] values = student.Split(",");
            StudentID = values[0];
            s_studentID = int.Parse(values[0].Remove(0,2));
            StudentName = values[1];
            FatherName = values[2];
            DOB = DateTime.Parse(values[3]);
            Gender = Enum.Parse<Gender>(values[4]);
            Physics = double.Parse(values[5]);
            Chemistry = double.Parse(values[6]);
            Maths = double.Parse(values[7]);
        }
    }
}