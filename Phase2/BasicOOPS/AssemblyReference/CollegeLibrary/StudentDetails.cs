using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeLibrary
{
    public enum Gender{Select, Male, Female, Transgender}

    public class StudentDetails
    {
        // Field

        private static int s_studentID = 1000;
        // Property

        public string StudentID { get; set; }

        public string  StudentName { get; set; }

        public string  FatherName { get; set; }

        public Gender  Gender { get; set; }

        public DateTime  DOB { get; set; }

        public long  Phone { get; set; }

        public double  Physics { get; set; }
        public double  Chemistry { get; set; }
        public double  Maths { get; set; }

        // Constructors
        public StudentDetails()
        {
            StudentName = "Enter Your name";
            FatherName = "Enter Your Father name";
            Gender = Gender.Select;
        }

        // Paramaterized Constructors
        public StudentDetails(string studentName, string fatherName, Gender gender, DateTime dob, long phone, double physics, double chemistry, double maths)
        {
            s_studentID++;
            StudentID = "SF" + s_studentID;

            // Assign parameter values to properties
            StudentName = studentName;
            FatherName = fatherName;
            Gender = gender;
            DOB = dob;
            Phone = phone;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }

        // Destructor
        ~StudentDetails()
        {
            System.Console.WriteLine("Destructor Called");
        }

        // Methods

        public bool CheckEligibility(double cutoff)
        {
            double average = (Physics+Chemistry+Maths)/3;
            if(average>=75)
            {
                return true;
            }
            else
            {
                return false;
            }
        }   

    }
}