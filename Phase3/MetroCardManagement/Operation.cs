using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class Operation
    {
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        public static CustomList<TravelHistory> travelHistoryList = new CustomList<TravelHistory>();
        public static CustomList<TicketFareDetails> ticketfareList = new CustomList<TicketFareDetails>();
        static UserDetails currentLoginUser;
        static TicketFareDetails currentTicket;
        public static void DefaultData()
        {
            UserDetails user1 = new UserDetails("Ravi", 9848812345, 1000);
            UserDetails user2 = new UserDetails("Baskaran", 9948854321, 1000);
            userList.Add(user1);
            userList.Add(user2);
            TravelHistory travel1 = new TravelHistory("CMRL1001", "Airport", "Egmore", new DateTime(2023, 10, 10), 55);
            TravelHistory travel2 = new TravelHistory("CMRL1001", "Egmore", "Koyambedu", new DateTime(2023, 10, 10), 32);
            TravelHistory travel3 = new TravelHistory("CMRL1002", "Alandur", "Koyambedu", new DateTime(2023, 11, 10), 25);
            TravelHistory travel4 = new TravelHistory("CMRL1002", "Egmore", "Thirumangalam", new DateTime(2023, 11, 10), 25);
            travelHistoryList.Add(travel1);
            travelHistoryList.Add(travel2);
            travelHistoryList.Add(travel3);
            travelHistoryList.Add(travel4);
            TicketFareDetails ticketfare1 = new TicketFareDetails("Airport", "Egmore", 55);
            TicketFareDetails ticketfare2 = new TicketFareDetails("Airport", "Koyambedu", 25);
            TicketFareDetails ticketfare3 = new TicketFareDetails("Alandur", "Koyambedu", 25);
            TicketFareDetails ticketfare4 = new TicketFareDetails("Koyambedu", "Egmore", 32);
            TicketFareDetails ticketfare5 = new TicketFareDetails("Vadapalani", "Egmore", 45);
            TicketFareDetails ticketfare6 = new TicketFareDetails("Arumbakkam", "Egmore", 25);
            TicketFareDetails ticketfare7 = new TicketFareDetails("Vadapalani", "Koyambedu", 25);
            TicketFareDetails ticketfare8 = new TicketFareDetails("Arumbakkam", "Koyambedu", 16);
            ticketfareList.Add(ticketfare1);
            ticketfareList.Add(ticketfare2);
            ticketfareList.Add(ticketfare3);
            ticketfareList.Add(ticketfare4);
            ticketfareList.Add(ticketfare5);
            ticketfareList.Add(ticketfare6);
            ticketfareList.Add(ticketfare7);
            ticketfareList.Add(ticketfare8);
            foreach (UserDetails user in userList)
            {
                System.Console.WriteLine($"| {user.CardNumber,-10} | {user.UserName,-15} | {user.PhoneNumber,-10} | {user.Balance,-10} |");
            }
            foreach (TravelHistory travel in travelHistoryList)
            {
                System.Console.WriteLine($"| {travel.TravelID,-10} | {travel.CardNumber,-10} | {travel.FromLocation,-15} | {travel.ToLocation,-15} | {travel.Date.ToString("dd/MM/yyyy"),-10} | {travel.TravelCost,-10} |");
            }
            foreach (TicketFareDetails ticket in ticketfareList)
            {
                System.Console.WriteLine($"| {ticket.TicketID,-10} | {ticket.FromLocation,-15} | {ticket.ToLocation,-15} | {ticket.TicketPrice,-10} |");
            }
        }
        public static void MainMenu()
        {
            System.Console.WriteLine("Welcome to Metro Card Management");
            bool mainMenuFlag = true;
            do
            {
                System.Console.WriteLine($"Main Menu: \nEnter the number to select the option\n1.New User Registration \n2.Login User \n3.Exit");
                int menuOption = int.Parse(Console.ReadLine());
                switch (menuOption)
                {
                    case 1:
                        {
                            NewUserRegistration();
                            break;
                        }
                    case 2:
                        {
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine($"Exit Selected. \nThank You!!!");
                            mainMenuFlag = false;
                            break;
                        }
                }

            } while (mainMenuFlag);
        }
        public static void NewUserRegistration()
        {
            System.Console.WriteLine($"New User Registration Option Selected \nEnter Your Name");
            string userName = Console.ReadLine();
            System.Console.WriteLine("Enter Your Phone Number");
            long phoneNumber = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your Balance");
            long balance = long.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(userName, phoneNumber, balance);
            userList.Add(user);
            System.Console.WriteLine($"Registered Successfully. \nYour Metro Card Number: {user.CardNumber}");
        }
        public static void UserLogin()
        {
            System.Console.WriteLine($"User Login Option Selected \nEnter Your Card Number to Login");
            string checkCardNumber = Console.ReadLine().ToUpper();
            currentLoginUser = Search.BinarySearch(checkCardNumber);
            if (currentLoginUser != null)
            {
                SubMenu();
            }
            else
            {
                System.Console.WriteLine("the card number you entered is not a valid one");
            }
            // bool cardNumberFlag = true;
            // foreach (UserDetails user in userList)
            // {
            //     if(user.CardNumber==checkCardNumber)
            //     {
            //         cardNumberFlag = false;
            //         currentLoginUser = user;
            //         SubMenu();
            //         break;

            //     }
            // }
            // if(cardNumberFlag)
            // {
            //     System.Console.WriteLine("the card number you entered is not a valid one");
            // }
        }
        public static void SubMenu()
        {
            System.Console.WriteLine("Logined Successfully...");
            bool subMenuFlag = true;
            do
            {
                System.Console.WriteLine("Enter the number to select the option \n1.Balance Check \n2.Recharge \n3.View Travel History \n4.Travel \n5.Exit");
                int subMenuOption = int.Parse(Console.ReadLine());
                switch (subMenuOption)
                {
                    case 1:
                        {
                            BalanceCheck();
                            break;
                        }
                    case 2:
                        {
                            Recharge();
                            break;
                        }
                    case 3:
                        {
                            ViewTravelHistory();
                            break;
                        }
                    case 4:
                        {
                            Travel();
                            break;
                        }
                    case 5:
                        {
                            System.Console.WriteLine($"Exit Selected.");
                            subMenuFlag = false;
                            break;
                        }
                }

            } while (subMenuFlag);
        }
        public static void BalanceCheck()
        {
            System.Console.WriteLine($"Your Wallet Balance: {currentLoginUser.Balance}");
        }
        public static void Recharge()
        {
            System.Console.WriteLine($"Recharge Option Selected \nDo you want to recharge? Yes or No");
            string rechargeDecision = Console.ReadLine().ToUpper();

            if (rechargeDecision == "YES")
            {
                System.Console.WriteLine("Enter the amount to recharge");
                double amount = double.Parse(Console.ReadLine());
                currentLoginUser.WalletRecharge(amount);
                System.Console.WriteLine($"Recharged Successfully. Your Current Wallet Balance is {currentLoginUser.Balance}");
            }
            else
            {
                System.Console.WriteLine("Exiting from recharge option");
            }
        }
        public static void ViewTravelHistory()
        
        {
            bool flag = true;
            foreach (TravelHistory travel in travelHistoryList)
            {
                if (currentLoginUser.CardNumber == travel.CardNumber)
                {
                    flag = false;
                    System.Console.WriteLine($"| {travel.TravelID,-10} | {travel.CardNumber,-10} | {travel.FromLocation,-15} | {travel.ToLocation,-15} | {travel.Date.ToString("dd/MM/yyyy"),-10} | {travel.TravelCost,-10} |");
                }
            }
            if (flag)
            {
                System.Console.WriteLine("You don't have any travel history");
            }
        }
        public static void Travel()
        {
            foreach (TicketFareDetails ticket in ticketfareList)
            {
                System.Console.WriteLine($"| {ticket.TicketID,-10} | {ticket.FromLocation,-15} | {ticket.ToLocation,-15} | {ticket.TicketPrice,-10} |");
            }
            System.Console.WriteLine("Enter the Ticket ID to boook for travel");
            string checkTicketID = Console.ReadLine().ToUpper();
            currentTicket = Search.BinarySearches(checkTicketID);
            if (currentTicket != null)
            {
                if (currentLoginUser.Balance >= currentTicket.TicketPrice)
                {
                    currentLoginUser.DeductBalance(currentTicket.TicketPrice);
                    TravelHistory travel = new TravelHistory(currentLoginUser.CardNumber, currentTicket.FromLocation, currentTicket.ToLocation, DateTime.Today, currentTicket.TicketPrice);
                    travelHistoryList.Add(travel);
                    System.Console.WriteLine($"Your Book is Confirmed. Your Travel ID is {travel.TravelID}");
                }
                else
                {
                    System.Console.WriteLine("You dont have enough balance in wallet. Please recharge youe wallet.");
                }
            }
            else
            {
                System.Console.WriteLine("Invalid Ticket ID");
            }

            // bool ticketIDFlag = true;
            // foreach (TicketFareDetails ticket in ticketfareList)
            // {
            //     if(checkTicketID==ticket.TicketID)
            //     {
            //         ticketIDFlag = false;
            //         if(currentLoginUser.Balance>=ticket.TicketPrice)
            //         {
            //             currentLoginUser.DeductBalance(ticket.TicketPrice);
            //             TravelHistory travel = new TravelHistory(currentLoginUser.CardNumber,ticket.FromLocation,ticket.ToLocation,DateTime.Today,ticket.TicketPrice);
            //             travelHistoryList.Add(travel);
            //             System.Console.WriteLine($"Your Book is Confirmed. Your Travel ID is {travel.TravelID}");
            //         }
            //         else
            //         {
            //             System.Console.WriteLine("You dont have enough balance in wallet. Please recharge youe wallet.");
            //         }
            //     }
            // }
            // if(ticketIDFlag)
            // {
            //     System.Console.WriteLine("Invalid Ticket ID");
            // }
        }
    }
}