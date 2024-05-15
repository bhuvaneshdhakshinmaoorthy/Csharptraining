using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayrollManagement1
{
    public class Operation
    {
        static List<EmployeeInfo> employeeList = new List<EmployeeInfo>();

        static EmployeeInfo currentLoginEmployee;
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Main Menu \n1.Registration \n2.Login \n3.Exit");
                int userDecision = int.Parse(Console.ReadLine());
                switch (userDecision)
                {
                    case 1:
                        {
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            Login();
                            break;
                        }
                    case 3:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void Registration()
        {
            Console.WriteLine("Enter your name");
            string employeName = Console.ReadLine();
            Console.WriteLine("Enter your role");
            string role = Console.ReadLine();
            Console.WriteLine("Enter your worklocation: AnnaNagar or Kilpauk?");
            WorkLocation workLocation = Enum.Parse<WorkLocation>(Console.ReadLine(), true);
            Console.WriteLine("Enter your Team Name");
            string teamName = Console.ReadLine();
            Console.WriteLine("Enter your Date of joining as dd/MM/yyyy");
            DateTime dateOfJoining = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine("Enter the total num of working days in month");
            int noOfWorkingDaysInMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your num of leave taken");
            int noOfLeaveTaken = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your gender: Male,Female,Others");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            EmployeeInfo employee = new EmployeeInfo(employeName, role, workLocation, teamName, dateOfJoining, noOfWorkingDaysInMonth, noOfLeaveTaken, gender);
            employeeList.Add(employee);
            Console.WriteLine($"You have successfully registered. \nYour userID is {employee.EmployeID}");
        }
        public static void Login()
        {
            Console.WriteLine("Enter your UserID");
            string checkUserID = Console.ReadLine().ToUpper();
            bool flag = false;
            foreach (EmployeeInfo employee in employeeList)
            {
                if (employee.EmployeID == checkUserID)
                {
                    flag = true;
                    currentLoginEmployee = employee;
                    SubMenu();
                }
            }
            if (!flag)
            {
                Console.WriteLine("Invalid UserID");
            }
        }
        public static void SubMenu()
        {
            Console.WriteLine("Login Successfully ");
            bool flag = true;
            do
            {
                Console.WriteLine("1.Calculate Salary \n2.Display Details \n3.Exit");
                int userDecision2 = int.Parse(Console.ReadLine());
                switch (userDecision2)
                {
                    case 1:
                        {
                            Console.WriteLine(currentLoginEmployee.SalaryCalculation());
                            break;
                        }
                    case 2:
                        {
                            Operation.DisplayDetails();
                            break;
                        }
                    case 3:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void DisplayDetails()
        {
            foreach (EmployeeInfo employe in employeeList)
            {
                if (employe.EmployeID == currentLoginEmployee.EmployeID)
                {
                    Console.WriteLine($"Employee Name: {currentLoginEmployee.EmployeName} \nRole: {currentLoginEmployee.Role} \nWorklocation: {currentLoginEmployee.WorkLocation} \nTeam Name: {currentLoginEmployee.EmployeName} \nDate of joining: {currentLoginEmployee.DateOfJoining.ToString("dd/MM/yyyy")} \nNum of working days in month: {currentLoginEmployee.NoOfWorkingDaysInMonth} \nNumber of leave taken: {currentLoginEmployee.EmployeName} \nGender: {currentLoginEmployee.Gender} ");
                }
            }
        }

    }
}
