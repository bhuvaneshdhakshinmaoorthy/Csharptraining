using System;
using System.Collections.Generic;
using CollegeLibrary;

namespace Application;
class  Program
{
    public static void Main(string[] args)
    {
        List<StudentDetails> studentList = new List<StudentDetails>();

        string option = "";
        do
        {
            Console.WriteLine("Student Registration Form");

            // StudentDetails student1 = new StudentDetails();

            Console.WriteLine("Enter your name");
            string studentName = Console.ReadLine(); 
            Console.WriteLine("Enter your father name");
            string fatherName = Console.ReadLine();
            Console.WriteLine("Enter your gender Male, Female, Transgender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.WriteLine("Enter your DOB dd/MM/yyyy");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine("Enter your phone number");
            long phone = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Physics mark");
            double physics = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Chemistry mark");
            double chemistry = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter your Maths mark");
            double maths = double.Parse(Console.ReadLine());
            

            StudentDetails student = new StudentDetails(studentName,fatherName,gender,dob,phone,physics,chemistry,maths);
            Console.WriteLine("You have registered successfully. Your ID " + student.StudentID);
            studentList.Add(student);

            Console.WriteLine("Do you want to continue");
            option = Console.ReadLine();
        } while (option=="yes");

        Console.WriteLine("Enter your student ID to login");
        string loginID = Console.ReadLine().ToUpper(); 

        bool flag = true;
        foreach( StudentDetails student in studentList)
        {
            if(student.StudentID==loginID)
            {
                flag = false;
                Console.WriteLine("Name " + student.StudentName+ "\nFatherName " + student.FatherName);
                Console.WriteLine("Gender " + student.Gender+ "\nDOB " + student.DOB.ToString("dd/MM/yyyy") + "\nPhone " + student.Phone);
                Console.WriteLine("Physics " + student.Physics+ "\nChemistry " + student.Chemistry + "\nMaths " + student.Maths);
                bool eligibilty = student.CheckEligibility(75);
                if(eligibilty)
                {
                    Console.WriteLine("You're eligible for admission");
                }
                else
                {
                    Console.WriteLine("You're not eligible for admission");
                }
            }
                  
        }
        if(flag)
        {
            Console.WriteLine("Invalid user ID");
        }    


        // GC.Collect();
        // GC.WaitForPendingFinaliazers();

        // System.Console.WriteLine("Code ending");
    }
}
