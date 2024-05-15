using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class Operation
    {
        public static List<UserDetails> userDatailsList = new List<UserDetails>();
        public static List<MedicineDetails> medcineList = new List<MedicineDetails>();
        public static List<OrderDetails> orderList = new List<OrderDetails>();
        static UserDetails currentLoginUser;

        public static void AddDefaultData()
        {
            UserDetails user1 = new UserDetails("Ravi", 33, "Theni", 9877774440, 400);
            UserDetails user2 = new UserDetails("Baskaran", 33, "Chennai", 8477757470, 500);
            userDatailsList.Add(user1);
            userDatailsList.Add(user2);
            MedicineDetails medicine1 = new MedicineDetails("Paracitamol", 40, 5, new DateTime(2023, 12, 30));
            MedicineDetails medicine2 = new MedicineDetails("Calpol", 10, 5, new DateTime(2023, 11, 30));
            MedicineDetails medicine3 = new MedicineDetails("Gelucil", 3, 40, new DateTime(2024, 04, 30));
            MedicineDetails medicine4 = new MedicineDetails("Metrogel", 5, 50, new DateTime(2024, 12, 30));
            MedicineDetails medicine5 = new MedicineDetails("Povidin Iodin", 10, 50, new DateTime(2026, 10, 30));
            medcineList.Add(medicine1);
            medcineList.Add(medicine2);
            medcineList.Add(medicine3);
            medcineList.Add(medicine4);
            medcineList.Add(medicine5);
            OrderDetails order1 = new OrderDetails("UID1001", "MD2001", 3, 15, new DateTime(2023, 11, 13), OrderStatus.Purchased);
            OrderDetails order2 = new OrderDetails("UID1001", "MD2002", 2, 10, new DateTime(2023, 11, 13), OrderStatus.Cancelled);
            OrderDetails order3 = new OrderDetails("UID1001", "MD2004", 2, 100, new DateTime(2023, 11, 13), OrderStatus.Purchased);
            OrderDetails order4 = new OrderDetails("UID1002", "MD2003", 3, 120, new DateTime(2024, 01, 15), OrderStatus.Cancelled);
            OrderDetails order5 = new OrderDetails("UID1002", "MD2005", 5, 250, new DateTime(2024, 01, 15), OrderStatus.Purchased);
            OrderDetails order6 = new OrderDetails("UID1002", "MD2002", 3, 15, new DateTime(2024, 01, 15), OrderStatus.Purchased);
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);
            orderList.Add(order4);
            orderList.Add(order5);
            orderList.Add(order6);
            foreach (UserDetails user in userDatailsList)
            {
                Console.WriteLine($"| {user.UserID,-10} | {user.UserName,-15} | {user.Age,-10} | {user.City,-15} | {user.PhoneNumber,-10} | {user.Balance,-10} |");
            }
            foreach (MedicineDetails medicine in medcineList)
            {
                Console.WriteLine($"| {medicine.MedicineID,-10} | {medicine.MedinceName,-15} | {medicine.AvailableCount,-10} | {medicine.Price,-10} | {medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-10} |");
            }
            foreach (OrderDetails order in orderList)
            {
                Console.WriteLine($"| {order.OrderID,-10} | {order.UserID,-10} | {order.MedicineID,-10} | {order.MedicineCount,-10} | {order.OrderDate.ToString("dd/MM/yyyy"),-10} | {order.OrderStatus,-15} |");
            }
        }
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to Online Medical store");
            bool flag = true;
            do
            {
                Console.WriteLine($"1.User Registration \n2.User Login \n3.Exit");
                int userDecision = int.Parse(Console.ReadLine());
                switch (userDecision)
                {
                    case 1:
                        {
                            UserRegistration();
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
        public static void UserRegistration()
        {
            Console.WriteLine("Enter your Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your PhoneNumber");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Balance");
            double balance = double.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(userName, age, city, phoneNumber, balance);
            userDatailsList.Add(user);
            Console.WriteLine($"Your registration was done successfuly. \nYour ID is {user.UserID}");
        }
        public static void Login()
        {
            Console.WriteLine("Enter the UserID to login");
            string checkID = Console.ReadLine().ToUpper();
            bool flag = false;
            foreach (UserDetails user in userDatailsList)
            {
                if (user.UserID == checkID)
                {
                    flag = true;
                    currentLoginUser = user;
                    SubMenu();
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Invalid UserID. Please enter a vlaid one");
            }
        }

        public static void SubMenu()
        {

            bool flag = true;
            do
            {
                Console.WriteLine($"1.Show medicine list \n2.Purchase Medicine \n3.Cancel Purchase \n4.Show Purchase History \n5.Recharge \n6.Show WalletBalance \n7.Exit");
                int userDecision2 = int.Parse(Console.ReadLine());
                switch (userDecision2)
                {
                    case 1:
                        {
                            ShowMedicineList();
                            break;
                        }
                    case 2:
                        {
                            PurchaseMedincine();
                            break;
                        }
                    case 3:
                        {
                            CancelPurchase();
                            break;
                        }
                    case 4:
                        {
                            ShowPurchaseHistory();
                            break;
                        }
                    case 5:
                        {
                            Recharge();
                            break;
                        }
                    case 6:
                        {
                            ShowWalletBalance();
                            break;
                        }
                    case 7:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }

        public static void ShowMedicineList()
        {
            foreach (MedicineDetails medicine in medcineList)
            {
                Console.WriteLine($"| {medicine.MedicineID,-10} | {medicine.MedinceName,-15} | {medicine.AvailableCount,-10} | {medicine.Price,-10} | {medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-10} |");
            }
        }
        public static void PurchaseMedincine()
        {
            // 1.Show the List of medicine details by traversing the medicine details list.
            foreach (MedicineDetails medicine in medcineList)
            {
                Console.WriteLine($"| {medicine.MedicineID,-10} | {medicine.MedinceName,-15} | {medicine.AvailableCount,-10} | {medicine.Price,-10} | {medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-10} |");
            }

            // 2.	Ask the user to select the medicine using MedicineID.
            Console.WriteLine("Enter the MedicineID to purchase the Medicine");
            string checkMedicineID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (MedicineDetails medicine in medcineList)
            {
                if (checkMedicineID == medicine.MedicineID)
                {
                    flag = false;
                    // 3.	Ask the number of counts of that medicine he wants to buy.
                    Console.WriteLine("Enter the count to purchase that medicine to buy");
                    int medicineCount = int.Parse(Console.ReadLine());

                    // 4.	Check the Medicine list whether the MedicineID was available. If it is available, then 
                    // a.	check the asked count is available. If it is available, then 
                    if (medicineCount <= medicine.AvailableCount)
                    {
                        // b.Check the medicine was not expired. If it is expired or not available, then show the user “Medicine is not available”.
                        if (medicine.DateOfExpiry > DateTime.Today)
                        {
                            // c.If the medicine is not expired, then check User has enough balance to purchase that medicine.
                            double totalPrice = medicineCount * medicine.Price;
                            if (currentLoginUser.Balance >= totalPrice)
                            {
                                // 5.Reduce the number of AvailableCount of that medicine in MedicineDetails.
                                medicine.AvailableCount -= medicineCount;
                                // medicine.AvailableCount = medicine.AvailableCount ;
                                // 6.Deduct the total amount from user’s balance amount.
                                currentLoginUser.Balance -= totalPrice;

                                // 7.If all the conditions specified in step 4 are true then calculate the total amount of purchased medicines, OrderDate is Now, Put OrderStatus as “Purchased” and create object for OrderDetails class and add it to the list. 
                                OrderDetails order = new OrderDetails(currentLoginUser.UserID, medicine.MedicineID, medicineCount, totalPrice, DateTime.Today, OrderStatus.Purchased);
                                orderList.Add(order);

                                // 8.Finally show the message “Medicine was purchased successfully”.
                                Console.WriteLine($"Medicine was purchased successfully. \nYour Medical ID is {order.OrderID}");
                            }
                            else
                            {
                                Console.WriteLine("You have insufficient balance to purchase the medicine. Please recharge your wallet and purchase again");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Medicine was expired");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Stock is not available");
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid MedicineID");
            }

        }
        public static void CancelPurchase()
        {
            // 1.	Show the order details of the currently logged in user whose order status is “Purchased”.
            bool flag = true;
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginUser.UserID == order.UserID && order.OrderStatus == OrderStatus.Purchased)
                {
                    Console.WriteLine($"| {order.OrderID,-10} | {order.UserID,-10} | {order.MedicineID,-10} | {order.MedicineCount,-10} | {order.TotalPrice,-10} | {order.OrderDate.ToString("dd/MM/yyyy"),-10} | {order.OrderStatus,-15} |");
                    flag = false;
                }
            }
            if (flag)
            {
                Console.WriteLine("You do not have any purchased order currently");
            }
            else
            {
                // 2. Get the OrderID information from the user and check the OrderID present in the list and check its OrderStatus is Purchased.
                Console.WriteLine("Enter the order ID to cancel the order");
                string cancelOrderID = Console.ReadLine().ToUpper();
                bool equal = true;
                foreach (OrderDetails order in orderList)
                {
                    if (order.OrderID == cancelOrderID && order.OrderStatus == OrderStatus.Purchased && currentLoginUser.UserID == order.UserID)
                    {
                        equal = false;
                        // 3. If the OrderID matches increase the count of that Medicine in the medicine details, Return the amount to the user.  Change the Status of the order to “Cancelled”.
                        order.OrderStatus = OrderStatus.Cancelled;
                        foreach (MedicineDetails medicine in medcineList)
                        {
                            if (medicine.MedicineID == order.MedicineID)
                            {
                                medicine.AvailableCount = medicine.AvailableCount + order.MedicineCount;
                            }
                        }
                        currentLoginUser.Balance += order.TotalPrice;
                        // 4. Show the user that the “OrderID XXX was cancelled successfully”. 
                        Console.WriteLine($"Your {order.OrderID} was cancelled successfully");
                    }
                }
                if (equal)
                {

                    Console.WriteLine("There is no order in the list to cancel");
                }
            }
        }
        public static void ShowPurchaseHistory()
        {
            bool flag = true;
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginUser.UserID == order.UserID)
                {
                    flag = false;
                    Console.WriteLine($"| {order.OrderID,-10} | {order.UserID,-10} | {order.MedicineID,-10} | {order.MedicineCount,-10} | {order.TotalPrice,-10}  | {order.OrderDate.ToString("dd/MM/yyyy"),-10} | {order.OrderStatus,-15} |");
                }
            }
            if (flag)
            {
                Console.WriteLine("You do not have any order currently");
            }
        }
        public static void Recharge()
        {
            Console.WriteLine("Whether do you want recharge your wallet");
            string userDecision3 = Console.ReadLine().ToUpper();
            if (userDecision3 == "YES")
            {
                Console.WriteLine("Enter the amount to recharge");
                double amount = double.Parse(Console.ReadLine());
                currentLoginUser.Balance += amount;
                Console.WriteLine($"Successfully recharged your wallet. \nYour Currenrt balance is {currentLoginUser.Balance}");
            }
        }
        public static void ShowWalletBalance()
        {
            Console.WriteLine($"Your wallet balance is {currentLoginUser.Balance}");
        }
    }
}