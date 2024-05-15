using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class FileHandling
    {
        public static void Create()
        {
            // For Folder
            if (!Directory.Exists("CafeteriaManagement"))
            {
                Directory.CreateDirectory("CafeteriaManagement");
                System.Console.WriteLine("Folder Created");
            }
            else
            {
                System.Console.WriteLine("Folder Already Exists");
            }
            // For User Details
            if(!File.Exists("CafeteriaManagement/UserDetails.csv"))
            {
                File.Create("CafeteriaManagement/UserDetails.csv").Close();
                System.Console.WriteLine("File Created");
            }
            else
            {
                System.Console.WriteLine("Already File Exists");
            }
            // For Food Detils
            if(!File.Exists("CafeteriaManagement/FoodDetails.csv"))
            {
                File.Create("CafeteriaManagement/FoodDetails.csv").Close();
            }
            else
            {
                System.Console.WriteLine("Already File Exists");
            }
            // For Cart Item Details
            if (!File.Exists("CafeteriaManagement/CartItemDetails.csv"))
            {
                File.Create("CafeteriaManagement/CartItemDetails.csv").Close();
                System.Console.WriteLine("File Created");
            }
            else
            {
                System.Console.WriteLine("Already File Exists");
            }
            // For Order Details
            if (!File.Exists("CafeteriaManagement/OrderDetails.csv"))
            {
                File.Create("CafeteriaManagement/OrderDetails.csv").Close();
                System.Console.WriteLine("File Created");
            }
            else
            {
                System.Console.WriteLine("Already File Exists");
            }
        }
        public static void WriteTOCSV()
        {
            // For User Details
            string[] user = new string[Operation.userList.Count];
            for(int i=0; i<Operation.userList.Count; i++)
            {
                user[i] = Operation.userList[i].UserID+","+ Operation.userList[i].Name+","+ Operation.userList[i].FatherName+","+ Operation.userList[i].MobileNumber+","+ Operation.userList[i].MailID+","+ Operation.userList[i].Gender+","+ Operation.userList[i].WorkStationNumber+","+ Operation.userList[i].WalletBalance;
            }
            File.WriteAllLines("CafeteriaManagement/UserDetails.csv",user);

            // For Food Detais
            string[] food = new string[Operation.foodList.Count];
            for (int i = 0; i < Operation.foodList.Count; i++)
            {
                food[i] = Operation.foodList[i].FoodID+","+ Operation.foodList[i].FoodName+","+ Operation.foodList[i].FoodPrice+"," + Operation.foodList[i].AvailableQuantity;
            }
            File.WriteAllLines("CafeteriaManagement/FoodDetails.csv",food);

            // For Cart Item Details
            string[] cart = new string[Operation.cartItemList.Count];
            for (int i = 0; i < Operation.cartItemList.Count; i++)
            {
                cart[i] = Operation.cartItemList[i].ItemID+","+ Operation.cartItemList[i].OrderID+","+ Operation.cartItemList[i].FoodID+","+ Operation.cartItemList[i].OrderPrice+","+ Operation.cartItemList[i].OrderQuantity;
            }
            File.WriteAllLines("CafeteriaManagement/CartItemDetails.csv",cart);

            // For Order Details
            string[] order = new string[Operation.orderList.Count];
            for (int i = 0; i < Operation.orderList.Count; i++)
            {
                order[i] = Operation.orderList[i].OrderID+","+ Operation.orderList[i].UserID+"," + Operation.orderList[i].OrderDate+","+ Operation.orderList[i].TotalPrice+"," + Operation.orderList[i].OrderStatus;
            }
            File.WriteAllLines("CafeteriaManagement/OrderDetails.csv",order);
        }
        public static void ReadFromCSV()
        {
            // To Read User Details
            string[] users = File.ReadAllLines("CafeteriaManagement/UserDetails.csv");
            foreach (string user in users)
            {
                UserDetails user1 = new UserDetails(user);
                Operation.userList.Add(user1);
            }

            // To Read Food Details
            string[] foods = File.ReadAllLines("CafeteriaManagement/FoodDetails.csv");
            foreach (string food in foods)
            {
                FoodDetails food1 = new FoodDetails(food);
                Operation.foodList.Add(food1);
            }

            // To Read Cart Item Details
            string[] carts = File.ReadAllLines("CafeteriaManagement/CartItemDetails.csv");
            foreach (string cart in carts)
            {
                CartItemDetails cart1 = new CartItemDetails(cart);
                Operation.cartItemList.Add(cart1);
            }

            // To Read Order Details
            string[] orders = File.ReadAllLines("CafeteriaManagement/OrderDetails.csv");
            foreach (string order in orders)
            {
                OrderDetails order1 = new OrderDetails(order);
                Operation.orderList.Add(order1);
            }
        }
    }
}