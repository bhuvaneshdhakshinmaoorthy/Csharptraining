using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineDTHRecharge
{
    public class Operation
    {
        static List<UserRegistration> userRegistrationList = new List<UserRegistration>();
        static List<PackDetails> packDetailsList = new List<PackDetails>();
        static List<RechargeHistory> rechargeHistoryList = new List<RechargeHistory>();
        static UserRegistration currentLoginUser;

        public static void AddDefaultData()
        {
            UserRegistration user1 = new UserRegistration("John", 9746646466, "john@gmail.com", 500);
            UserRegistration user2 = new UserRegistration("Merlin", 9782136543, "merlin@gmail.com", 5000);
            userRegistrationList.Add(user1);
            userRegistrationList.Add(user2);
            PackDetails pack1 = new PackDetails("RC150", "Pack1", 150, 28, 50);
            PackDetails pack2 = new PackDetails("RC300", "Pack2", 300, 56, 75);
            PackDetails pack3 = new PackDetails("RC500", "Pack3", 500, 28, 200);
            PackDetails pack4 = new PackDetails("RC1500", "Pack4", 1500, 365, 200);
            packDetailsList.Add(pack1);
            packDetailsList.Add(pack2);
            packDetailsList.Add(pack3);
            packDetailsList.Add(pack4);
            RechargeHistory recharge1 = new RechargeHistory("UID1001", "RC150", new DateTime(2021, 11, 30), 150, new DateTime(2021, 12, 27), 50);
            RechargeHistory recharge2 = new RechargeHistory("UID1002", "RC150", new DateTime(2022, 01, 01), 500, new DateTime(2024, 04, 23), 50);
            rechargeHistoryList.Add(recharge1);
            rechargeHistoryList.Add(recharge2);
            foreach (UserRegistration user in userRegistrationList)
            {
                Console.WriteLine($"| {user.UserName,-15} | {user.MobileNumber,-10} | {user.EmailID,-20} | {user.WalletBalance,-10} |");
            }
            foreach (PackDetails pack in packDetailsList)
            {
                Console.WriteLine($"| {pack.PackID,-10} | {pack.PackName,-10} | {pack.Price,-10} | {pack.Validity,-10} | {pack.NoOfChannels,-10} |");
            }
            foreach (RechargeHistory recharge in rechargeHistoryList)
            {
                Console.WriteLine($"| {recharge.RechargeID,-10} | {recharge.UserID,-10} | {recharge.PackID,-10} | {recharge.DateTime.ToString("dd/MM/yyyy", null),-10} | {recharge.RechargeAmount,-10} | {recharge.ValidTill.ToString("dd/MM/yyyy", null),-10} | {recharge.NoOfChannels,-10} |");
            }
        }
        public static void MainMenu()
        {

            bool flag = true;
            do
            {
                Console.WriteLine("Welcome to Dish DTH \n1.User Registration \n2.User Login \n3.Exit");
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
            Console.WriteLine("Enter your Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your Mobile Number");
            long mobileNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your MailID");
            string emailID = Console.ReadLine();
            Console.WriteLine("Enter your Wallet Balance");
            double walletBalance = double.Parse(Console.ReadLine());

            UserRegistration user = new UserRegistration(userName, mobileNumber, emailID, walletBalance);
            userRegistrationList.Add(user);

            Console.WriteLine($"You have successfully done your registration process\nYour User ID: {user.UserID}");

            foreach (UserRegistration userr in userRegistrationList)
            {
                if (user.UserID == userr.UserID)
                {
                    Console.WriteLine($"| {userr.UserName,-15} | {userr.MobileNumber,-10} | {userr.EmailID,-20} | {userr.WalletBalance,-10} |");
                }
            }
        }
        public static void Login()
        {
            Console.WriteLine("Enter your UserID");
            string checkID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (UserRegistration user in userRegistrationList)
            {
                if (user.UserID == checkID)
                {
                    flag = false;
                    currentLoginUser = user;
                    Console.WriteLine("Login Successfully");
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid UserID");
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Select an option for further action\n1.Current pack \n2.Pack recharge \n3.Wallet recharge \n4.View pack recharge history \n5.Show wallet balance \n6.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            CurrentPack();
                            break;
                        }
                    case 2:
                        {
                            PackRecharge();
                            break;
                        }
                    case 3:
                        {
                            WalletRecharge();
                            break;
                        }
                    case 4:
                        {
                            ViewPackRechargeHistory();
                            break;
                        }
                    case 5:
                        {
                            ShowWalletBalance();
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
        public static void CurrentPack()
        {
            bool flag = true;
            foreach (RechargeHistory recharge in rechargeHistoryList)
            {
                if (currentLoginUser.UserID == recharge.UserID && recharge.ValidTill >= DateTime.Today)
                {
                    flag = false;
                    Console.WriteLine($"| {recharge.UserID,-10} | {recharge.PackID,-10} | {recharge.RechargeAmount,-10} | {recharge.ValidTill.ToString("dd/MM/yyyy", null),-10} | {recharge.NoOfChannels,-10} |");
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Currently you do not have active plan");
            }
        }
        public static void PackRecharge()
        {
            // 1.	List the available pack details and ask the user to choose a pack and recharge.
            foreach (PackDetails pack in packDetailsList)
            {
                Console.WriteLine($"| {pack.PackID,-10} | {pack.PackName,-10} | {pack.Price,-10} | {pack.Validity,-10} | {pack.NoOfChannels,-10} |");
            }
            Console.WriteLine("Enter any PackID to pack recharge");
            string packDecisionID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (PackDetails pack in packDetailsList)
            {
                if (pack.PackID == packDecisionID)
                {
                    flag = false;
                    // 2. Based on the pack choose, check the wallet balance.
                    if (currentLoginUser.WalletBalance >= pack.Price)
                    {
                        // 4.	If the user has sufficient balance, then permit and do recharge. 
                        DateTime temp = new DateTime();
                        foreach(RechargeHistory recharge in rechargeHistoryList)
                        {
                            if(currentLoginUser.UserID==recharge.UserID)
                            {
                                temp = recharge.ValidTill;
                            }
                        }
                        DateTime rechargeValidity = DateTime.Today.AddDays(pack.Validity-1);
                        if(temp>=DateTime.Today)
                        {
                            rechargeValidity = DateTime.Today.Add(temp - DateTime.Today).AddDays(pack.Validity);
                        }
                        RechargeHistory recharges = new RechargeHistory(currentLoginUser.UserID, pack.PackID, DateTime.Today, pack.Price,rechargeValidity, pack.NoOfChannels);
                        rechargeHistoryList.Add(recharges);
                        currentLoginUser.WalletBalance -= pack.Price;
                        Console.WriteLine("You have done your recharge successfully");

                    }
                    // 3.	If insufficient balance in wallet, ask them to recharge his wallet.
                    else
                    {
                        Console.WriteLine("Insufficient Wallet balance. Please recharge you wallet");
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid PackID");
            }
        }
        public static void WalletRecharge()
        {
            foreach (UserRegistration user in userRegistrationList)
            {
                if (currentLoginUser.UserID == user.UserID)
                {
                    Console.WriteLine("Whether do you want to add the wallet amount");
                    string decision = Console.ReadLine().ToUpper();
                    if (decision == "YES")
                    {
                        Console.WriteLine("How much amount do you want to add in your wallet");
                        double recharge = double.Parse(Console.ReadLine());
                        currentLoginUser.WalletBalance += recharge;
                        Console.WriteLine($"Your current wallet balance is {currentLoginUser.WalletBalance}");
                    }
                    else
                    {
                        Console.WriteLine("Cancelled the Wallet recharge process");
                    }
                }
            }
        }
        public static void ViewPackRechargeHistory()
        {
            bool flag = true;
            foreach (RechargeHistory recharge in rechargeHistoryList)
            {
                if (recharge.UserID == currentLoginUser.UserID)
                {
                    flag = false;
                    Console.WriteLine($"| {recharge.RechargeID,-10} | {recharge.UserID,-10} | {recharge.PackID,-10} | {recharge.DateTime.ToString("dd/MM/yyyy", null),-10} | {recharge.RechargeAmount,-10} | {recharge.ValidTill.ToString("dd/MM/yyyy", null),-10} | {recharge.NoOfChannels,-10} |");
                }
            }
            if (flag)
            {
                Console.WriteLine("You do not have any recharge history");
            }
        }
        public static void ShowWalletBalance()
        {
            
                    Console.WriteLine($"Your current wallet balance is {currentLoginUser.WalletBalance}");
        }
    }
}