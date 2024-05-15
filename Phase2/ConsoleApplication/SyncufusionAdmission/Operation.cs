using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncufusionAdmission
{

    public static class Operation
    {
        public static CustomList<StudentDetails> studentList = new CustomList<StudentDetails>();
        public static CustomList<DepartmentDetails> departmentList = new CustomList<DepartmentDetails>();
        public static CustomList<AdmissionDetails> admissionList = new CustomList<AdmissionDetails>();
        static StudentDetails currentLoginStudent;

        public static void AddDefaultData()
        {
            // Console.WriteLine("Hello");
            // Create list fore all classes
            // create object
            // Add to List
            // traverse and show added data
            // List<StudentDetails> studentList = new List<StudentDetails>();
            // List<DepartmentDetails> departmentList = new List<DepartmentDetails>();
            // List<AdmissionDetails> admissionList = new List<AdmissionDetails>();

            StudentDetails student1 = new StudentDetails("Ravichandran E", "Ettapparajan", new DateTime(1999, 11, 11), Gender.Male, 95, 95, 95);
            StudentDetails student2 = new StudentDetails("Baskaran S", "Sethurajan", new DateTime(1997, 12, 11), Gender.Male, 95, 95, 95);
            studentList.Add(student1);
            studentList.Add(student2);
            DepartmentDetails department1 = new DepartmentDetails("EEE", 29);
            DepartmentDetails department2 = new DepartmentDetails("CSE", 29);
            DepartmentDetails department3 = new DepartmentDetails("MECH", 30);
            DepartmentDetails department4 = new DepartmentDetails("ECE", 30);
            departmentList.Add(department1);
            departmentList.Add(department2);
            departmentList.Add(department3);
            departmentList.Add(department4);
            AdmissionDetails admission1 = new AdmissionDetails("SF3001", "DID101", new DateTime(2022, 05, 11), AdmissionStatus.Admitted);
            AdmissionDetails admission2 = new AdmissionDetails("SF3001", "DID101", new DateTime(2022, 05, 11), AdmissionStatus.Admitted);
            admissionList.Add(admission1);
            admissionList.Add(admission2);

            foreach (StudentDetails students in studentList)
            {
                System.Console.WriteLine($"|  {students.StudentID,-10} | {students.StudentName,-15} | {students.FatherName,-15} | {students.DOB.ToString("dd/MM/yyyy"),10} | {students.Gender,-15} | {students.Physics,-10} | {students.Chemistry,-10} | {students.Maths,-10}");
            }
            foreach (DepartmentDetails departments in departmentList)
            {
                System.Console.WriteLine($"|  {departments.DepartmentID,-10} | {departments.DepartmentName,-15} | {departments.NumberOfSeats,-10} ");
            }
            foreach (AdmissionDetails admissions in admissionList)
            {
                System.Console.WriteLine($"|  {admissions.AdmissionID,-10} | {admissions.StudentID,-10} | {admissions.DepartmentID,-10} | {admissions.AdmissionDate.ToString("dd/MM/yyyy"),-10} | {admissions.AdmissionStatus,-15}");
            }
        }

        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Syncfusion Application Process: \n1.Student Registration \n2.Student Login \n3.Exit");
                int userdecision = int.Parse(Console.ReadLine());
                switch (userdecision)
                {
                    case 1:
                        {
                            // Console.WriteLine("Registration Selected");
                            Operation.Registration();
                            break;
                        }
                    case 2:
                        {
                            // Console.WriteLine("Login Selected");
                            Operation.Login();
                            break;
                        }
                    case 3:
                        {
                            // Console.WriteLine("Exit Selected");
                            flag = false;
                            break;
                        }
                }

            } while (flag);
        }

        public static void Registration()
        {
            Console.WriteLine("Registration Process Selected");
            Console.WriteLine("Enter your Name");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter your Father Name");
            string fatherName = Console.ReadLine();
            Console.WriteLine("Enter your Date Of Birth");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine("Enter your Gender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.WriteLine("Enter your Physics Mark");
            double physics = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Chemistry Mark");
            double chemistry = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Math Mark");
            double maths = double.Parse(Console.ReadLine());

            StudentDetails students = new StudentDetails(studentName, fatherName, dob, gender, physics, chemistry, maths);
            studentList.Add(students);
            System.Console.WriteLine($"Student Registered Successfully and StudentID is {students.StudentID}");
        }

        public static void Login()
        {
            Console.WriteLine("Login Process Selected");
            // Get User ID
            // Traverse StudentList
            // Find User is present 
            // If User id is not present, show invalid user ID
            // If ID present store current cookie object globally
            // Then  show the submenu 
            Console.WriteLine("Enter UserID");
            string loginID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (StudentDetails student in studentList)
            {
                if (loginID == student.StudentID)
                {
                    Console.WriteLine("Login Successfully");
                    flag = false;
                    currentLoginStudent = student;
                    Operation.SubMenu();
                    break;
                    // Console.WriteLine()
                }

            }
            if (flag)
            {
                Console.WriteLine("Invalid User ID");
            }
        }
        public static void SubMenu()
        {
            Console.WriteLine("Submenu Option Selected");
            bool flag = true;
            do
            {
                Console.WriteLine("Which do you want to do \n1.Check Eligibility \n2.Show Details \n3.Take Admission \n4.Cancel Admission \n5.Show Admission Details \n6.Exit");
                int option2 = int.Parse(Console.ReadLine());
                switch (option2)
                {
                    case 1:
                        {
                            Operation.CheckEligibility();
                            break;
                        }
                    case 2:
                        {
                            Operation.ShowDetails();
                            break;
                        }
                    case 3:
                        {
                            Operation.TakeAdmission();
                            break;
                        }
                    case 4:
                        {
                            Operation.CancelAdmission();
                            break;
                        }
                    case 5:
                        {
                            Operation.ShowAdmissionDetails();
                            break;
                        }
                    case 6:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void CheckEligibility()
        {
            bool temp = currentLoginStudent.IsEligible(75);
            if (temp == true)
            {
                Console.WriteLine("Student is eligible for admission");
            }
            else
            {
                Console.WriteLine("Student is not eligible for admission");
            }
        }
        public static void ShowDetails()
        {
            System.Console.WriteLine($"|  {currentLoginStudent.StudentID,-10} | {currentLoginStudent.StudentName,-15} | {currentLoginStudent.FatherName,-15} | {currentLoginStudent.DOB.ToString("dd/MM/yyyy"),10} | {currentLoginStudent.Gender,-15} | {currentLoginStudent.Physics,-10} | {currentLoginStudent.Chemistry,-10} | {currentLoginStudent.Maths,-10}");
        }
        public static void TakeAdmission()
        {
            // Show the list of available departments and number of seats available by traversing the department details list
            foreach (DepartmentDetails departments in departmentList)
            {
                System.Console.WriteLine($"|  {departments.DepartmentID,-10} | {departments.DepartmentName,-15} | {departments.NumberOfSeats,-10} ");
            }
            // Ask the student to pick one DepartmentID.
            Console.WriteLine("Pick One DepartmentID");
            string departmentID = Console.ReadLine().ToUpper();
            // Validate the DepartmentID is present in the list.
            bool flag = true;
            foreach (DepartmentDetails department in departmentList)
            {
                if (department.DepartmentID == departmentID)
                {
                    flag = false;
                    bool temp = currentLoginStudent.IsEligible(75);
                    if (temp)
                    {
                        // If it is present, then check whether he is eligible to take admission.
                        // If he is eligible, check whether seat available or not, if seats available then Check whether the student has already taken any admission by traversing admission details list. If he didn’t took any admission previously. 
                        if (department.NumberOfSeats > 0)
                        {
                            // if seats available then Check whether the student has already taken any admission by traversing admission details list. If he didn’t took any admission previously. 
                            bool admissionStatusFlag = true;
                            foreach (AdmissionDetails admission in admissionList)
                            {
                                if (currentLoginStudent.StudentID == admission.AdmissionID && admission.AdmissionStatus == AdmissionStatus.Admitted)
                                {
                                    admissionStatusFlag = false;

                                }
                                else
                                {
                                    Console.WriteLine("You were already taken Admission");
                                }
                            }
                            // Then, Reduce the seat count in department list and create admission details object by using StudentID, DepartmentID, AdmissionDate as Now, AdmissionStatus and Booked and add it to list.
                            if (admissionStatusFlag)
                            {
                                department.NumberOfSeats--;
                                AdmissionDetails admission = new AdmissionDetails(currentLoginStudent.StudentID, department.DepartmentID, DateTime.Now, AdmissionStatus.Admitted);
                                admissionList.Add(admission);
                                // Finally show “Admission took successfully. Your admission ID – SF3001”.
                                Console.WriteLine($"Admission took successfully. Your admission ID {admission.AdmissionID}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Seat Available");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not eligible");
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid Department ID");
            }
        }

        public static void CancelAdmission()

        {
            // Show the current logged in student’s admission detail by traversing the list which AdmissionStatus Property is Booked.If fount then show it.
            bool flag = true;
            foreach (AdmissionDetails admissions in admissionList)
            {
                if (currentLoginStudent.StudentID == admissions.StudentID && admissions.AdmissionStatus == AdmissionStatus.Admitted)
                {
                    flag = false;
                    // Change the Admission status property to Cancelled.
                    admissions.AdmissionStatus = AdmissionStatus.Cancelled;
                    // Return the seat to Department Details list
                    foreach (DepartmentDetails department in departmentList)
                    {
                        if (department.DepartmentID == admissions.AdmissionID)
                        {
                            department.NumberOfSeats++;
                        }
                    }
                    // Finally show admission cancelled successfully.
                    Console.WriteLine("Admission Cancelled Successfully");
                }

            }
            if (flag)
            {
                Console.WriteLine("You have not taken any Admission");
            }




        }
        public static void ShowAdmissionDetails()
        {
            bool flag = true;
            foreach (AdmissionDetails admissions in admissionList)
            {
                if (currentLoginStudent.StudentID == admissions.AdmissionID)
                {
                    flag = false;
                    System.Console.WriteLine($"|  {admissions.AdmissionID,-10} | {admissions.StudentID,-10} | {admissions.DepartmentID,-10} | {admissions.AdmissionDate.ToString("dd/MM/yyyy"),-10} | {admissions.AdmissionStatus,-15}");
                }
            }
            if (flag)
            {
                Console.WriteLine("You are not taken any admission");
            }
        }
    }
}