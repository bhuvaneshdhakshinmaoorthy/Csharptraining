using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBBillCalculation1
{
    public class Operation
    {
        static List<UserRegistration> userRegistrationList = new List<UserRegistration>();

        static UserRegistration currentLoginUser;
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to EB Bill portal");
            bool flag = true;
            do
            {
                Console.WriteLine("1.Registration \n2.Login \n3.Exit");
                int userDecision1 = int.Parse(Console.ReadLine());
                switch(userDecision1)
                {
                    case 1:
                    {
                        Operation.Registration();
                        break;
                    }
                    case 2:
                    {
                        Operation.Login();
                        break;
                    }
                    case 3:
                    {
                        flag = false;
                        break;
                    }
                }
            }while(flag);
        }
        public static void Registration()
        {
            Console.WriteLine("Enter your Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your MailID");
            string mailID = Console.ReadLine();
            Console.WriteLine("Enter the number of units used");
            double unitsUsed = double.Parse(Console.ReadLine());
            UserRegistration user = new UserRegistration(userName,phoneNumber,mailID,unitsUsed);
            userRegistrationList.Add(user);
            Console.WriteLine($"Your registration was done. Your MeterID is {user.MeterID}");
        }
        public static void Login()
        {
            Console.WriteLine("Enter your MeterID");
            string checkMeterID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach(UserRegistration user in userRegistrationList)
            {
                if(user.MeterID==checkMeterID)
                {
                    flag = false;
                    currentLoginUser = user;
                    SubMenu();
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid UserID");
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("1.Calculate Amount \n2.Display User Details \n3.Exit");
                int userDecision2 = int.Parse(Console.ReadLine());
                switch(userDecision2)
                {
                    case 1:
                    {
                        Console.WriteLine(currentLoginUser.CalculateAmountMethod());
                        break;
                    }
                    case 2:
                    {
                        DisplayUserDetails();
                        break;
                    }
                    case 3:
                    {
                        flag = false;
                        break;
                    }
                }
            }while(flag);
        }
        public static void DisplayUserDetails()
        {
            Console.WriteLine($"| {currentLoginUser.MeterID} |  {currentLoginUser.UserName} | {currentLoginUser.PhoneNumber} | {currentLoginUser.MailID} |");
        }
    }
}