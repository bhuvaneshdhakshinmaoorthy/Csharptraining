using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApplicationSynccart
{
    public class Operation
    {
        static List<CustomerDetails> customerList = new List<CustomerDetails>();
        static List<ProductDetails> productList = new List<ProductDetails>();
        static List<OrderDetails> orderList = new List<OrderDetails>();
        static CustomerDetails currentLoginCustomer;
        public static void AddDefaultData()

        {
            CustomerDetails customer1 = new CustomerDetails("Ravi", "Chennai", 9885858588, 50000, "ravi@mail.com");
            CustomerDetails customer2 = new CustomerDetails("Baskaran", "Chennai", 9888475757, 200000, "ravi@mail.com");
            customerList.Add(customer1);
            customerList.Add(customer2);
            ProductDetails product1 = new ProductDetails("Mobile (Samsung)", 10, 10000, 3);
            ProductDetails product2 = new ProductDetails("Tablet (Lenovo)", 5, 15000, 2);
            ProductDetails product3 = new ProductDetails("Camara (Sony)", 3, 20000, 4);
            ProductDetails product4 = new ProductDetails("iPhone", 5, 50000, 6);
            ProductDetails product5 = new ProductDetails("Laptop (Lenovo I3)", 3, 40000, 3);
            ProductDetails product6 = new ProductDetails("HeadPhone (Boat)", 5, 1000, 2);
            ProductDetails product7 = new ProductDetails("Speakers (Boat)", 4, 500, 2);
            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            productList.Add(product7);
            OrderDetails order1 = new OrderDetails("CID3001", "PID2001", 20000, DateTime.Now, 2, OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails("CID3002", "PID2002", 40000, DateTime.Now, 2, OrderStatus.Ordered);
            orderList.Add(order1);
            orderList.Add(order2);
            foreach (CustomerDetails customer in customerList)
            {
                Console.WriteLine($"| {customer.CustomerID,-10} | {customer.CustomerName,-15} | {customer.City,-15} | {customer.Phone,-10} | {customer.WalletBalance,-10} | {customer.MailID,-15} |");
            }
            foreach (ProductDetails product in productList)
            {
                Console.WriteLine($"| {product.ProductID,-10} | {product.ProductName,-20} | {product.Stock,-10} | {product.Price,-10} | {product.ShippingDuration,-10} |");
            }
            foreach (OrderDetails order in orderList)
            {
                Console.WriteLine($"| {order.OrderID,-10} | {order.CustomerID,-10} | {order.ProductID,-10} | {order.TotalPrice,-10} | {order.PurchaseDate.ToString("dd/MM/yyyy"),-10} | {order.Quantity,-10} | {order.OrderStatus,-15} |");
            }
        }
        public static void MainMenu()

        {
            bool flag = true;
            do
            {
                Console.WriteLine("Welcome to Synccart \n1. Customer Registration \n2. Login \n3. Exit");
                int userdecision = int.Parse(Console.ReadLine());
                switch (userdecision)
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
            Console.WriteLine("Registration Process Selected");
            Console.WriteLine("Enter your Name");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter your City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your Mobile Number");
            long phone = long.Parse(Console.ReadLine());
            Console.WriteLine("Add your Walletbalance");
            double walletBalance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Mail ID");
            string mailID = Console.ReadLine();

            CustomerDetails customer = new CustomerDetails(customerName, city, phone, walletBalance, mailID);
            customerList.Add(customer);
            Console.WriteLine($"You have successfully created a account in Synccart. Your Synccart ID is {customer.CustomerID}");
        }
        public static void Login()
        {
            Console.WriteLine("Enter your Customer ID");
            string loginID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (CustomerDetails customer in customerList)
            {
                if (loginID == customer.CustomerID)
                {
                    Console.WriteLine("Login Successfully");
                    flag = false;
                    currentLoginCustomer = customer;
                    SubMenu();
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
            Console.WriteLine("Submenu Option Selected");
            bool flag = true;
            do
            {
                Console.WriteLine("Which do you want to do \n1. Purchase \n2. Order History \n3. Cancel Order \n4. WalletBalance \n5. WalletRecharge \n6. Exit");
                int option2 = int.Parse(Console.ReadLine());
                switch (option2)
                {
                    case 1:
                        {
                            Purchase();
                            break;
                        }
                    case 2:
                        {
                            OrderHistory();
                            break;
                        }
                    case 3:
                        {
                            CancelOrder();
                            break;
                        }
                    case 4:
                        {
                            WalletBalance();
                            break;
                        }
                    case 5:
                        {
                            WalletRecharge();
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
        public static void Purchase()
        {
            // 1. Once the Customer logged in show the list of Products. Ask the customer to select a Product using Product ID. 
            foreach (ProductDetails product in productList)
            {
                Console.WriteLine($"| {product.ProductID,-10} | {product.ProductName,-20} | {product.Stock,-10} | {product.Price,-10} | {product.ShippingDuration,-10} |");
            }
            Console.WriteLine("Select the product ID to purchase the product");
            string userdecisionProductID = Console.ReadLine().ToUpper();

            // 2. Validate productID if it is invalid show “Invalid ProductID”.
            bool flag = true;
            foreach (ProductDetails product in productList)
            {
                if (userdecisionProductID == product.ProductID)
                {
                    // 3. If it is valid, Then ask for the count he wish to purchase.
                    flag = false;
                    Console.WriteLine("How many count do you want to purchase?");
                    int quantity = int.Parse(Console.ReadLine());
                    if (quantity <= product.Stock)
                    {
                        // 5. If the count is available calculate total amount with the below formula.
                        // Delivery charge is Rs 50
                        // Total Amount = (required count * price per quantity) + Delivery charge
                        int deliveryCharge = 50;
                        double totalPrice = (quantity * product.Price) + deliveryCharge;
                        Console.WriteLine($"The Total Amount for the product along with the delivery charges is: {totalPrice}");

                        // 6. Check the current logged in customer’s wallet balance to ensure he is having enough balance to purchase by comparing with total price.
                        if (totalPrice <= currentLoginCustomer.WalletBalance)
                        {
                            // 8. If the wallet has sufficient balance, then 
                            // a. Deduct the total amount from the wallet balance of the current logged in customer.
                            double deductbalance = totalPrice;
                            currentLoginCustomer.DeductBalanceMethod(deductbalance);
                            Console.WriteLine($"Money debited from your wallet. \nYour wallet Balance: {currentLoginCustomer.WalletBalance}");
                            
                            // b. Deduct the count from the stock availability of the product.
                            product.Stock = product.Stock - quantity;

                            // 9. Create order with available details and make its status as Ordered, add it to order List and show “Order Placed Successfully. Order ID: OID1001”.
                            OrderDetails orders = new OrderDetails(currentLoginCustomer.CustomerID, product.ProductID, totalPrice, DateTime.Now, quantity, OrderStatus.Ordered);
                            orderList.Add(orders);
                            Console.WriteLine($"Order Placed Succeussfully. Your order ID is {orders.OrderID}");

                            // 10. Show the delivery date of order by making a calculation based on purchase date and shipping duration of the product like “Order placed successfully. Your order will be delivered on {Order date +shipping duration of the product}.
                            DateTime delivery = DateTime.Today.AddDays(product.ShippingDuration);
                            Console.WriteLine($"Order placed successfully. Your order will be delivered on {delivery.ToString("dd/MM/yyyy")}");

                        }
                        
                        // 7. If the wallet balance is insufficient for this order, then display “Insufficient Wallet Balance. Please recharge your wallet and do purchase again”.
                        else
                        {
                            Console.WriteLine("Insufficient Wallet balance. Please recharge your wallet and do purchase again");
                        }
                    }
                    // 4. If the required count is not available in the product’s stock, then show like “Required count not available. Current availability is {product’s stock count}”.
                    else
                    {
                        Console.WriteLine($"Current availability is {product.Stock}");
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid ProductID");
            }
        }
        public static void OrderHistory()
        {
            bool flag = true;
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginCustomer.CustomerID == order.CustomerID)
                {
                    flag = false;
                    Console.WriteLine($"| {order.OrderID,-10} | {order.CustomerID,-10} | {order.ProductID,-10} | {order.TotalPrice,-10} | {order.PurchaseDate.ToString("dd/MM/yyyy"),-10} | {order.Quantity,-10} | {order.OrderStatus,-15} |");
                }
            }
            if (flag)
            {
                Console.WriteLine("You do not have any order history");
            }
        }
        public static void CancelOrder()
        {
            bool flag = true;
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginCustomer.CustomerID == order.CustomerID && order.OrderStatus == OrderStatus.Ordered)
                {
                    Console.WriteLine($"| {order.OrderID,-10} | {order.CustomerID,-10} | {order.ProductID,-10} | {order.TotalPrice,-10} | {order.PurchaseDate.ToString("dd/MM/yyyy"),-10} | {order.Quantity,-10} | {order.OrderStatus,-15} |");
                    flag = false;
                }
            }
            if (flag)
            {
                Console.WriteLine("You do not have any order currently");
            }
            else
            {
                Console.WriteLine("Which order you want to be cancelled?\nEnter the orderID");
                string checkOrderID = Console.ReadLine().ToUpper();
                bool equal = true;
                foreach (OrderDetails order in orderList)
                {
                    if (currentLoginCustomer.CustomerID == order.CustomerID && order.OrderStatus == OrderStatus.Ordered && order.OrderID == checkOrderID)
                    {
                        equal = false;
                        order.OrderStatus = OrderStatus.Cancelled;

                        foreach (ProductDetails product in productList)
                        {
                            if ( product.ProductID == order.ProductID )
                            {
                                product.Stock += order.Quantity;
                                break;
                            }
                        }
                        currentLoginCustomer.WalletBalance += order.TotalPrice;
                        Console.WriteLine($"Order:{order.OrderID} cancelled successfully");
                    }
                }
                if (equal)
                {
                    Console.WriteLine("Invalid OrderID");
                }
            }
        }
        public static void WalletBalance()
        {
            Console.WriteLine($"Your Wallet Balance: {currentLoginCustomer.WalletBalance}");
        }
        public static void WalletRecharge()
        {
            Console.WriteLine("Whether do you want to recharge the wallet?");
            string decision = Console.ReadLine().ToUpper();
            if (decision == "YES")
            {
                Console.WriteLine("Enter the amount to recharge your wallet balance");
                double rechargeAmount = double.Parse(Console.ReadLine());
                Console.WriteLine($"Successfully recharged your wallet. \nYour Wallet Balance: {currentLoginCustomer.ForRecharge(rechargeAmount)}");
            }
        }
    }
}
