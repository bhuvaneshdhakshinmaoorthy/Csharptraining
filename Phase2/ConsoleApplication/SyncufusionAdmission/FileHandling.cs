using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SyncufusionAdmission
{
    public class FileHandling
    {
        public static void Create()
        {
            // Create Folder
            if (!Directory.Exists("SyncufusionAdmission"))
            {
                System.Console.WriteLine("Creating Folder...");
                Directory.CreateDirectory("SyncufusionAdmission");
            }
            else
            {
                System.Console.WriteLine("Already Folder Exists in that name");
            }
            // Create File
            // for student
            if (!File.Exists("SyncufusionAdmission/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("SyncufusionAdmission/StudentDetails.csv").Close();
            }
            else
            {
                System.Console.WriteLine("Already File Exists in that name");
            }
            // for department
            if (!File.Exists("SyncufusionAdmission/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("SyncufusionAdmission/DepartmentDetails.csv").Close();
            }
            else
            {
                System.Console.WriteLine("Already File Exists in that name");
            }
            // for Admission
            if (!File.Exists("SyncufusionAdmission/AdmissionDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("SyncufusionAdmission/AdmissionDetails.csv").Close();
            }
            else
            {
                System.Console.WriteLine("Already File Exists int that name");
            }
        }

        public static void WriteToCSV()
        {
            // Student info
            string[] students = new string[Operation.studentList.Count];
            for (int i = 0; i < Operation.studentList.Count; i++)
            {
                students[i] = Operation.studentList[i].StudentID + "," + Operation.studentList[i].StudentName + "," + Operation.studentList[i].FatherName + "," + Operation.studentList[i].DOB.ToString("dd/MM/yyyy") + "," + Operation.studentList[i].Gender + "," + Operation.studentList[i].Physics + "," + Operation.studentList[i].Chemistry + "," + Operation.studentList[i].Maths + ",";
            }
            File.WriteAllLines("SyncufusionAdmission/StudentDetails.csv", students);

            // Department Info
            string[] department = new string[Operation.departmentList.Count];
            for (int i = 0; i < Operation.departmentList.Count; i++)
            {
                department[i] = Operation.departmentList[i].DepartmentID + "," + Operation.departmentList[i].DepartmentName + "," + Operation.departmentList[i].NumberOfSeats + ",";
            }
            File.WriteAllLines("SyncufusionAdmission/DepartmentDetails.csv",department);
            // for admission
            string[] admission = new string[Operation.admissionList.Count];
            for(int i=0; i<Operation.admissionList.Count; i++)
            {
                admission[i] = Operation.admissionList[i].AdmissionID + "," + Operation.admissionList[i].StudentID + "," + Operation.admissionList[i].DepartmentID + "," + Operation.admissionList[i].AdmissionDate.ToString("dd/MM/yyyy") + "," + Operation.admissionList[i].AdmissionStatus + "," ;
            }
            File.WriteAllLines("SyncufusionAdmission/AdmissionDetails.csv",admission);
        }

        public static void ReadFromCSV()
        {
            // For Student 
            string[] students = File.ReadAllLines("SyncufusionAdmission/StudentDetails.csv");
            foreach(string student in students)
            {
                StudentDetails student1 = new StudentDetails(student);
                Operation.studentList.Add(student1);
            }
            //  For Department
            string[] departments = File.ReadAllLines("SyncufusionAdmission/DepartmentDetails.csv");
            foreach(string department in departments)
            {
                DepartmentDetails department1 = new DepartmentDetails(department);
                Operation.departmentList.Add(department1);
            }
            string[] admissions = File.ReadAllLines("SyncufusionAdmission/AdmissionDetails.csv");
            foreach(string admission in admissions)
            {
                AdmissionDetails admission1 = new AdmissionDetails(admission);
                Operation.admissionList.Add(admission1);

            }
        }
    }
}