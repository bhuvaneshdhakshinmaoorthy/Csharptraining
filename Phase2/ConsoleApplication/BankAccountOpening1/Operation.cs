using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountOpening1
{
    public class Operation
    {
        static List<BankPortal> bankAccount = new List<BankPortal>();
        static BankPortal currentLoginCustomer;
        public static void MainMenu()
        {

            bool flag = true;
            do
            {
                Console.WriteLine("Wlcome to HDFC Bank portal \nMain Menu: \n1. Registration \n2. Login \n3.Exit");
                int userDecision = int.Parse(Console.ReadLine());
                switch (userDecision)
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
            } while (flag);
        }
        public static void Registration()
        {
            Console.WriteLine("Enter your Name");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter your balance");
            double balance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your gender Male, Female, Others");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.WriteLine("Enter your phone number");
            long phone = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your mailID");
            string mailID = Console.ReadLine();
            Console.WriteLine("Enter your DOB as dd/MM/yyyy");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            BankPortal customer = new BankPortal(customerName, balance, gender, phone, mailID, dob);
            bankAccount.Add(customer);
            Console.WriteLine($"You have successfully registered your account \nYour HDFC customer ID is {customer.CustomerID}");
        }
        public static void Login()
        {
            Console.WriteLine("Enter your HDFC used ID");
            string userID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (BankPortal customer in bankAccount)
            {
                if (userID == customer.CustomerID)
                {
                    flag = false;
                    currentLoginCustomer = customer;
                    Operation.SubMenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid User ID");
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("SubMenu \n1.Deposit \n2.Withdraw \n3.Balance check \n4.Exit");
                int userDecision2 = int.Parse(Console.ReadLine());
                switch (userDecision2)
                {
                    case 1:
                        {
                            Operation.Deposit();
                            break;
                        }
                    case 2:
                        {
                            Operation.Withdraw();
                            break;
                        }
                    case 3:
                        {
                            Operation.BalanceCheck();
                            break;
                        }
                    case 4:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void Deposit()
        {
            Console.WriteLine("Enter your deposit amount:");
            double depositAmount = double.Parse(Console.ReadLine());
            currentLoginCustomer.DepositMethod(depositAmount);
            Console.WriteLine($"Your current balance is: {currentLoginCustomer.Balance}");
        }
        public static void Withdraw()
        {
            Console.WriteLine("Enter your Withdraw amount:");
            double withdrawnAmount = double.Parse(Console.ReadLine());
            bool temp = currentLoginCustomer.Withdrawn(withdrawnAmount);
            if (temp == true)
            {
                Console.WriteLine(currentLoginCustomer.Balance);
            }
            else
            {
                Console.WriteLine("You have Insufficient balance");
            }
            
        }
        public static void BalanceCheck()
        {
            Console.WriteLine(currentLoginCustomer.Balance);
        }

    }
}