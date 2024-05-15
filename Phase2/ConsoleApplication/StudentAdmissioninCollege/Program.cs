using System;
using System.Collections.Generic;

namespace StudentAdmissioninCollege;
class Program
{
    public static void Main(string[] args)
    {
        List<StudentAdmission> studentApplication = new List<StudentAdmission>();

        string option = "";
        int userDecision;
        // int userDecision2=0;
        do
        {
            Console.WriteLine("Do you want to do 1. Student Registration 2. Student Login 3.Exit \nJust Enter the number only");
            userDecision = int.Parse(Console.ReadLine());
            switch (userDecision)
            {
                case 1:
                    {
                        do
                        {
                            Console.WriteLine("Enter your Name");
                            string studentName = Console.ReadLine();

                            Console.WriteLine("Enter your Father Name");
                            string fatherName = Console.ReadLine();

                            Console.WriteLine("Enter your DOB as dd/MM/yyyy");
                            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                            Console.WriteLine("Enter your Gender - Male, Female, Transgender");
                            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

                            Console.WriteLine("Enter your Physics Mark");
                            double physics = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter your Chemistry Mark");
                            double chemistry = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter your Maths Mark");
                            double maths = int.Parse(Console.ReadLine());

                            StudentAdmission student = new StudentAdmission(studentName, fatherName, dob, gender, physics, chemistry, maths);
                            studentApplication.Add(student);
                            Console.WriteLine($"Student Registered Successfully and StudentID is {student.StudentID}");

                            Console.WriteLine("Do you want to continue");
                            option = Console.ReadLine();

                        } while (option == "yes");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter your student ID to login");
                        string loginId = Console.ReadLine();

                        bool flag = true;
                        foreach(StudentAdmission students in studentApplication)
                        {
                            if(students.StudentID==loginId)
                            {
                                flag false;
                            }
                        }
                        if(flag)
                        {
                            Console.WriteLine("Invalid User ID");
                        }
                        break;
                    }
                case 3:
                    {
                        break;
                    }
            }
        } while(userDecision!=3);
        // userdecison2==3||
    }
}