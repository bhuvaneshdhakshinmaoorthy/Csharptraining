using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class Operation
    {
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        public static CustomList<FoodDetails> foodList = new CustomList<FoodDetails>();
        public static CustomList<CartItemDetails> cartItemList = new CustomList<CartItemDetails>();
        public static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        static UserDetails currentLoginUser;

        public static void DefaultData()
        {
            UserDetails user1 = new UserDetails("Ravichandran", "Ettapparajan", 8857777575, "ravi@gmail.com", Gender.Male, "WS101", 400);
            UserDetails user2 = new UserDetails("Baskaran", "Sethurajan", 9577747744, "baskaran@gmail.com", Gender.Male, "WS105", 500);
            userList.Add(user1);
            userList.Add(user2);
            FoodDetails food1 = new FoodDetails("Coffee", 20, 100);
            FoodDetails food2 = new FoodDetails("Tea", 15, 100);
            FoodDetails food3 = new FoodDetails("Biscuit", 10, 100);
            FoodDetails food4 = new FoodDetails("Juice", 50, 100);
            FoodDetails food5 = new FoodDetails("Puff", 40, 100);
            FoodDetails food6 = new FoodDetails("Milk", 10, 100);
            FoodDetails food7 = new FoodDetails("Popcorn", 20, 20);
            foodList.Add(food1);
            foodList.Add(food2);
            foodList.Add(food3);
            foodList.Add(food4);
            foodList.Add(food5);
            foodList.Add(food6);
            foodList.Add(food7);
            CartItemDetails cart1 = new CartItemDetails("OID1001", "FID101", 20, 1);
            CartItemDetails cart2 = new CartItemDetails("OID1001", "FID103", 10, 1);
            CartItemDetails cart3 = new CartItemDetails("OID1001", "FID105", 40, 1);
            CartItemDetails cart4 = new CartItemDetails("OID1002", "FID103", 10, 1);
            CartItemDetails cart5 = new CartItemDetails("OID1002", "FID104", 50, 1);
            CartItemDetails cart6 = new CartItemDetails("OID1002", "FID105", 40, 1);
            cartItemList.Add(cart1);
            cartItemList.Add(cart2);
            cartItemList.Add(cart3);
            cartItemList.Add(cart4);
            cartItemList.Add(cart5);
            cartItemList.Add(cart6);
            OrderDetails order1 = new OrderDetails("SF1001", new DateTime(2022, 06, 15), 70, OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails("SF1002", new DateTime(2022, 06, 15), 100, OrderStatus.Ordered);
            orderList.Add(order1);
            orderList.Add(order2);
            foreach (UserDetails user in userList)
            {
                System.Console.WriteLine($"| {user.UserID,-10} | {user.Name,-15} | {user.FatherName,-15} | {user.MobileNumber,-10} | {user.MailID,-18} | {user.Gender,-10} | {user.WorkStationNumber,-10} | {user.WalletBalance,-10} |");
            }
            foreach (FoodDetails food in foodList)
            {
                System.Console.WriteLine($"| {food.FoodID,-10} | {food.FoodPrice,-12} | {food.FoodPrice,-10} | {food.AvailableQuantity,-10} |");
            }
            foreach (CartItemDetails cart in cartItemList)
            {
                System.Console.WriteLine($"| {cart.ItemID,-10} | {cart.OrderID,-10} | {cart.FoodID,-10} | {cart.OrderPrice,-10} | {cart.OrderQuantity,-10} |");
            }
            foreach (OrderDetails order in orderList)
            {
                System.Console.WriteLine($"| {order.OrderID,-10} | {order.UserID,-10} | {order.OrderDate.ToString("dd/MM/yyyy"),-10} | {order.TotalPrice,-10} | {order.OrderStatus,-10} |");
            }
        }
        public static void MainMenu()
        {
            System.Console.WriteLine("Welcome to Cafeteria Card Mangement");
            bool flag = true;
            do
            {
                Console.WriteLine("MainMenu: \nEnter a number to select the option \n1.User Registration \n2.User Login \n3.Exit");
                int userDecision1 = int.Parse(Console.ReadLine());
                switch (userDecision1)
                {
                    case 1:
                        {
                            UserRegistration();
                            break;
                        }
                    case 2:
                        {
                            UserLogin();
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
            Console.WriteLine("Registration process selected");
            System.Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your Father Name");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter your Mobile Number");
            long mobileNumber = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your MailID");
            string mailID = Console.ReadLine();
            System.Console.WriteLine("Enter your Gender: Male,Female,Others");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            System.Console.WriteLine("Enter your Work Station Number");
            string workStationNumber = Console.ReadLine().ToUpper();
            System.Console.WriteLine("Enter your Balance");
            double balance = double.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(name, fatherName, mobileNumber, mailID, gender, workStationNumber, balance);
            userList.Add(user);

            System.Console.WriteLine($"Your registration is done successfuly.\nYour userID is {user.UserID}");
        }
        public static void UserLogin()
        {
            Console.WriteLine("Login process selected");
            Console.WriteLine("Enter your UserID");
            string checkUserID = Console.ReadLine().ToUpper();
            currentLoginUser = Search.BinarySearch(checkUserID);
            
            if (currentLoginUser!=null)
            {
                // currentLoginUser ;
                System.Console.WriteLine("Logined Successfully");
                SubMenu();
            }
            else
            {
                System.Console.WriteLine("Invalid User ID. Please enter a valid one");
            }

            // bool flag = true;
            // foreach (UserDetails user in userList)
            // {
            //     if (user.UserID == checkUserID)
            //     {
            //         flag = false;
            //         currentLoginUser = user;
                    
            //         break;
            //     }
            // }                    
            // if (flag)
            // {
            //     Console.WriteLine("Invalid User ID. Please enter a valid one");
            // }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine($"SubMenu: \nEnter a number to select the option \n1.Show My Profile \n2.Food Order \n3.Modify Order \n4.Cancel Order \n5.Order History \n6.Wallet Recharge \n7.Show Wallet Balance \n8.Exit");
                int userDecision2 = int.Parse(Console.ReadLine());
                switch (userDecision2)
                {
                    case 1:
                        {
                            ShowMyProfile();
                            break;
                        }
                    case 2:
                        {
                            FoodOrder();
                            break;
                        }
                    case 3:
                        {
                            ModifyOrder();
                            break;
                        }
                    case 4:
                        {
                            CancelOrder();
                            break;
                        }
                    case 5:
                        {
                            OrderHistory();
                            break;
                        }
                    case 6:
                        {
                            WalletRecharge();
                            break;
                        }
                    case 7:
                        {
                            ShowWalletBalance();
                            break;
                        }
                    case 8:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void ShowMyProfile()
        {
            foreach (UserDetails user in userList)
            {
                if (user.UserID == currentLoginUser.UserID)
                {
                    System.Console.WriteLine($"| {user.UserID,-10} | {user.Name,-15} | {user.FatherName,-15} | {user.MobileNumber,-10} | {user.MailID,-18} | {user.Gender,-10} | {user.WorkStationNumber,-10} | {user.WalletBalance,-10} |");
                }
            }
        }
        public static void FoodOrder()
        {



            // 1.	Create a temporary local carItemtList.
            List<CartItemDetails> localCartItemList = new List<CartItemDetails>();
            // 2.	Create an Order object with current UserID, Order date as current DateTime, total price as 0, Order status as “Initiated”.
            OrderDetails order = new OrderDetails(currentLoginUser.UserID, DateTime.Today, 0, OrderStatus.Initiated);

            double TotalPrice = 0;
            string userWish1 = "";
            do
            {
                foreach (FoodDetails food in foodList)
                {
                    System.Console.WriteLine($"| {food.FoodID,-10} | {food.FoodPrice,-12} | {food.FoodPrice,-10} | {food.AvailableQuantity,-10} |");
                }
                // 3.	Ask the user to pick a product using FoodID, quantity required and calculate price of food.
                System.Console.WriteLine("Enter the FoodID");
                string checkFoodID = Console.ReadLine();
                System.Console.WriteLine("Enter the Quantity");
                int checkFoodQuantity = int.Parse(Console.ReadLine());
                bool first = true;
                foreach (FoodDetails food in foodList)
                {
                    if (food.FoodID == checkFoodID)
                    {
                        first = false;
                        // 4.	If the food and quantity available, reduce the quantity from the food object’s “AvailableQuantity” then create CartItems object using the available data.
                        if (checkFoodQuantity<=food.AvailableQuantity)
                        {
                            food.AvailableQuantity -= checkFoodQuantity;
                            double price = food.FoodPrice * checkFoodQuantity;
                            TotalPrice = price;
                            // 5.	Add that object it to local CartItemsList to add it to cart wish list.
                            CartItemDetails cart = new CartItemDetails(order.OrderID, food.FoodID, price, checkFoodQuantity);
                            localCartItemList.Add(cart);
                            // 6.	Ask the user whether he want to pick another product.
                            System.Console.WriteLine("Whether you want to pick another product? Yes or No");
                            userWish1 = Console.ReadLine().ToUpper();
                        }
                        else
                        {
                            System.Console.WriteLine("Food Quantity is not available");
                        }
                    }
                }
                if (first)
                {
                    System.Console.WriteLine("Invalid FoodID");
                }
                // 7.	If “Yes” then show the updated Food Details and repeat from step “3”.
                // 8.	Repeat the process until the user enters “No”.
            } while (userWish1 == "YES");

            // 9.	If He says No then, 
            System.Console.WriteLine("whether you confirm the wish list to purchase? Yes or No");
            string userWish2 = Console.ReadLine().ToUpper();
            // 11.	If he says “Yes” then, Calculate the total price of the food items selected using the local CartItemList information and check the balance from the user details whether it has sufficient balance to purchase.
            // 12.	If he has enough balance, then deduct the respective amount from the user’s balance. 
            if (userWish2 == "YES")
            {
                bool temp = false;
                do
                {


                    if (TotalPrice <= currentLoginUser.WalletBalance)
                    {
                        temp = false;
                        // 13.	Append the local CartItemList to global CartItemList.
                        cartItemList.AddRange(localCartItemList);
                        // 14.	Modify Order object created at step 1’s total price as total OrderPrice and OrderStatus as “Ordered”. 
                        order.OrderStatus = OrderStatus.Ordered;
                        order.TotalPrice = TotalPrice;
                        currentLoginUser.DeductAmountMethod(TotalPrice);
                        // 15.	Then add the Order object to the Order list.
                        orderList.Add(order);
                        // 16.	Show “Order placed successfully, and OrderID is OID1001”.
                        System.Console.WriteLine($"Order placed successfully, and OrderID is {order.OrderID}");

                    }
                    else
                    {
                        System.Console.WriteLine("Insufficient Balance");
                        System.Console.WriteLine("Are you willing to recharge? Yes or No");
                        string choice = Console.ReadLine().ToUpper();
                        if (choice == "YES")
                        {
                            temp = true;
                            System.Console.WriteLine("Enter the amount recharge");
                            double amount = double.Parse(Console.ReadLine());
                            if (amount > 0)
                            {
                                currentLoginUser.WalletRechargeMethod(amount);
                                System.Console.WriteLine($"Your Current Wallet Balance is {currentLoginUser.WalletBalance}");
                            }
                            else
                            {
                                System.Console.WriteLine("Enter Valid Amount");
                            }
                        }
                        else
                        {
                            temp = false;
                            foreach (CartItemDetails cart in localCartItemList)
                            {
                                foreach (FoodDetails food in foodList)
                                {
                                    if (food.FoodID == cart.FoodID)
                                    {
                                        food.AvailableQuantity += cart.OrderQuantity;
                                        break;
                                    }
                                }
                            }
                        }

                    }
                } while (temp);
            }
            // 10.	Ask the user whether he confirm the wish list to purchase. If he says “No” then traverse the local CartItemList and get the Items one by one and reverse the quantity to the FoodItem’s objects in the foodList.
            else
            {

                foreach (CartItemDetails cart in localCartItemList)
                {
                    foreach (FoodDetails food in foodList)
                    {
                        if (food.FoodID == cart.FoodID)
                        {
                            food.AvailableQuantity += cart.OrderQuantity;
                            break;
                        }
                    }
                }
            }


        }
        public static void ModifyOrder()
        {
            bool flag = true;
            // 1.	Show the Order details of current logged in user to pick an Order detail by using OrderID and whose status is “Ordered”. Check whether the order details is present. If yes then,
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginUser.UserID == order.UserID && order.OrderStatus == OrderStatus.Ordered)
                {
                    flag = false;
                    System.Console.WriteLine($"| {order.OrderID,-10} | {order.UserID,-10} | {order.OrderDate.ToString("dd/MM/yyyy"),-10} | {order.TotalPrice,-10} | {order.OrderStatus,-10} |");
                }
            }
            if (flag)
            {
                System.Console.WriteLine("You didn't have any order");
            }
            else
            {
                System.Console.WriteLine("Enter the OrerID to modify");
                string checkOrderID = Console.ReadLine();
                bool orderIDFlag = true;
                foreach (OrderDetails order in orderList)
                {
                    if (currentLoginUser.UserID == order.UserID && order.OrderStatus == OrderStatus.Ordered && order.OrderID==checkOrderID)
                    {
                        // 2.	Show list of Cart Item details and ask the user to pick an Item id.
                        foreach (CartItemDetails cart in cartItemList)
                        {
                            if (order.OrderID == cart.OrderID)
                            {
                                orderIDFlag = false;
                                System.Console.WriteLine($"| {cart.ItemID,-10} | {cart.OrderID,-10} | {cart.FoodID,-10} | {cart.OrderPrice,-10} | {cart.OrderQuantity,-10} |");
                            }
                        }
                    }
                }
                if (orderIDFlag)
                {
                    System.Console.WriteLine("Invalid Food ID");
                }
                else
                {
                    System.Console.WriteLine("Enter the modify to ItemID");
                    string checkItemID = Console.ReadLine().ToUpper();
                    bool itemIDFlag = true;
                    // double price = 0;
                    foreach (OrderDetails order in orderList)
                    {
                        if (currentLoginUser.UserID == order.UserID && order.OrderStatus == OrderStatus.Ordered && order.OrderID==checkOrderID)
                        {
                            // 3.	Ensure the ItemID is available and ask the user to enter the new quantity of the food. Calculate the Item price and update in the OrderPrice.
                            foreach (CartItemDetails cart in cartItemList)
                            {
                                if (order.OrderID == cart.OrderID && cart.ItemID==checkItemID)
                                {
                                    itemIDFlag = false;
                                    System.Console.WriteLine("Enter the quantity to modify");
                                    int checkFoodQuan = int.Parse(Console.ReadLine());
                                    

                                    bool quantityFlag = true;
                                    foreach (FoodDetails food in foodList)
                                    {
                                        // checkFoodQuan<food.AvailableQuantity &&
                                        if(cart.FoodID==food.FoodID)
                                        {
                                            quantityFlag = false;

                                            if(checkFoodQuan<=food.AvailableQuantity)
                                            {
                                                food.AvailableQuantity -= checkFoodQuan;
                                                int finalQuantityCheck = cart.OrderQuantity - checkFoodQuan;
                                                if(finalQuantityCheck==0)
                                                {
                                                    System.Console.WriteLine("Same Quantity Entered");
                                                }
                                                else if(finalQuantityCheck<0)
                                                {
                                                    cart.OrderQuantity += finalQuantityCheck;
                                                    double returnAmount =- finalQuantityCheck * food.FoodPrice;  
                                                    currentLoginUser.WalletRechargeMethod(returnAmount);
                                                    food.AvailableQuantity += finalQuantityCheck;
                                                    System.Console.WriteLine("Order Modified Successfully");
                                                    // order.
                                                }
                                                else
                                                {
                                                    double returnAmount = finalQuantityCheck * food.FoodPrice;
                                                    if(currentLoginUser.WalletBalance>returnAmount)
                                                    {
                                                        cart.OrderQuantity += finalQuantityCheck;
                                                        currentLoginUser.DeductAmountMethod(returnAmount);
                                                        food.AvailableQuantity -= finalQuantityCheck;
                                                        System.Console.WriteLine("Order Modified Successfully");
                                                    }
                                                }
                                            }
                                            // price = food.FoodPrice * checkFoodQuan;                                            
                                            // if(price<=currentLoginUser.WalletBalance)
                                            // {
                                            //     food.AvailableQuantity -= checkFoodQuan;
                                            //     currentLoginUser.DeductAmountMethod(price);
                                            //     order.TotalPrice += price;
                                            //     cart.OrderQuantity += checkFoodQuan;
                                            //     cart.OrderPrice += price; 
                                            //     System.Console.WriteLine("Order Modified Successfully");
                                            //     break;
                                            // }
                                            // else
                                            // {
                                            //     System.Console.WriteLine("Insufficient Balance");
                                            // }
                                            
                                        }
                                        else if(food.AvailableQuantity==checkFoodQuan)
                                        {
                                            System.Console.WriteLine("Same Quantity Entered");
                                        }
                                        else
                                        {

                                        }
                                    }
                                    if(quantityFlag)
                                    {
                                        System.Console.WriteLine("Quantity not available");
                                    }

                                    
                                }
                            }
                            
                            break;
                            
                        }
                    }
                    if (itemIDFlag)
                    {
                        System.Console.WriteLine("Invalid Item ID");
                    }
                }
            }

            // 4.	Calculate the total price of Items and update in Order details entry. 
            // 5.	Show Order modified successfully.

        }
        public static void CancelOrder()
        {
            // 1.	Show the Order details of the current user who’s Order status is “Ordered”.
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginUser.UserID == order.OrderID && order.OrderStatus == OrderStatus.Ordered)
                {
                    System.Console.WriteLine($"| {order.OrderID,-10} | {order.UserID,-10} | {order.OrderDate.ToString("dd/MM/yyyy"),-10} | {order.TotalPrice,-10} | {order.OrderStatus,-10} |");
                }
            }
            // 2.	Ask the user to pick an OrderID to cancel.
            System.Console.WriteLine("Enter the OrderID to cancel");
            string checkOrderID = Console.ReadLine();

            // 3.	Check the OrderID is valid. If not, then show “Invalid OrderID”.
            bool temp = true;
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginUser.UserID == order.OrderID && order.OrderStatus == OrderStatus.Ordered)
                {
                    // 4.	If valid, then Return the Order total amount to current user. 
                    if (order.OrderID == checkOrderID)
                    {
                        temp = false;

                        currentLoginUser.WalletRechargeMethod(order.TotalPrice);
                        // 5.	Return product orderQuantity to Foodtem list’s FoodQuantity. 
                        foreach (CartItemDetails cart in cartItemList)
                        {
                            if (cart.OrderID == order.OrderID)
                            {
                                foreach (FoodDetails food in foodList)
                                {
                                    if (cart.FoodID == food.FoodID)
                                    {
                                        food.AvailableQuantity += cart.OrderQuantity;
                                    }
                                }
                            }
                        }
                        // 6.	Change the OrderStatus as Cancelled.
                        order.OrderStatus = OrderStatus.Cancelled;
                        // 7.	Show “Order cancelled successfully” and product returned to cart.
                        System.Console.WriteLine("Order cancelled successfully");

                    }
                }
            }
            if (temp)
            {
                System.Console.WriteLine("Invalid OrderID");
            }

            // 5.	Return product orderQuantity to Foodtem list’s FoodQuantity. 
            // 6.	Change the OrderStatus as Cancelled.
            // 7.	Show “Order cancelled successfully” and product returned to cart.

        }
        public static void OrderHistory()
        {
            bool flag = true;
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginUser.UserID == order.UserID)
                {
                    flag = false;
                    System.Console.WriteLine($"| {order.OrderID,-10} | {order.UserID,-10} | {order.OrderDate.ToString("dd/MM/yyyy"),-10} | {order.TotalPrice,-10} | {order.OrderStatus,-10} |");
                }
            }
            if (flag)
            {
                System.Console.WriteLine("You don't have any order history");
            }
        }
        public static void WalletRecharge()
        {
            System.Console.WriteLine("Wallet Recharge Process Selected \nWhether do you want to recharge? Yes or No");
            string userAnswer = Console.ReadLine().ToUpper();
            if (userAnswer == "YES")
            {
                System.Console.WriteLine("Enter the amount to recharge");
                double amount = double.Parse(Console.ReadLine());
                currentLoginUser.WalletRechargeMethod(amount);
            }
        }
        public static void ShowWalletBalance()
        {
            foreach (UserDetails user in userList)
            {
                if (currentLoginUser.UserID == user.UserID)
                {
                    System.Console.WriteLine($"Your Current Wallet Balance is {user.WalletBalance}");
                }
            }
        }

    }
}