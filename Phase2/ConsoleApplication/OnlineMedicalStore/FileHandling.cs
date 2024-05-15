using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public static class FileHandling
    {
        public static void Create()
        {
            // For folder
            if (!Directory.Exists("OnlineMedicalStore"))
            {
                Directory.CreateDirectory("OnlineMedicalStore");
                System.Console.WriteLine("Folder Created");
            }
            else
            {
                System.Console.WriteLine("Already Folder Exists");
            }
            // Creating file
            // File for User Details
            if (!File.Exists("OnlineMedicalStore/UserDetails.csv"))
            {
                File.Create("OnlineMedicalStore/UserDetails.csv").Close();
                System.Console.WriteLine("File Created");
            }
            else
            {
                System.Console.WriteLine("Already File Exists");
            }
            // File for Medicine Details
            if (!File.Exists("OnlineMedicalStore/MedicineDetails.csv"))
            {
                File.Create("OnlineMedicalStore/MedicineDetails.csv").Close();
                System.Console.WriteLine("File Created");
            }
            else
            {
                System.Console.WriteLine("Already File Exists");
            }
            // File for Order Details
            if (!File.Exists("OnlineMedicalStore/OrderDetails.csv"))
            {
                File.Create("OnlineMedicalStore/OrderDetails.csv").Close();
                System.Console.WriteLine("File Created");
            }
            else
            {
                System.Console.WriteLine("Already File Exists");
            }
        }
        public static void WriteToCSV()
        {
            // To Write in File

            // For User Details
            string[] users = new string[Operation.userDatailsList.Count];
            for(int i=0; i<Operation.userDatailsList.Count; i++)
            {
                users[i] = Operation.userDatailsList[i].UserID+","+ Operation.userDatailsList[i].UserName+","+ Operation.userDatailsList[i].Age+","+ Operation.userDatailsList[i].City+","+ Operation.userDatailsList[i].PhoneNumber+","+ Operation.userDatailsList[i].Balance;
            }
            File.WriteAllLines("OnlineMedicalStore/UserDetails.csv",users);

            // For Medicine Details
            string[] medicines = new string[Operation.medcineList.Count];
            for(int i=0; i<Operation.medcineList.Count; i++)
            {
                medicines[i] = Operation.medcineList[i].MedicineID+","+ Operation.medcineList[i].MedinceName+","+ Operation.medcineList[i].AvailableCount+","+ Operation.medcineList[i].Price+"," + Operation.medcineList[i].DateOfExpiry.ToString("dd/MM/yyyy");
            }
            File.WriteAllLines("OnlineMedicalStore/MedicineDetails.csv",medicines);

            // For Order Details
            string[] orders = new string[Operation.orderList.Count];
            for(int i=0; i<Operation.orderList.Count; i++)
            {
                orders[i] = Operation.orderList[i].OrderID+","+ Operation.orderList[i].UserID+","+ Operation.orderList[i].MedicineID+","+ Operation.orderList[i].MedicineCount+","+ Operation.orderList[i].TotalPrice+","+ Operation.orderList[i].OrderDate.ToString("dd/MM/yyyy")+","+ Operation.orderList[i].OrderStatus;
            }
            File.WriteAllLines("OnlineMedicalStore/OrderDetails.csv",orders);
        }
        public static void ReadFromCSV()
        {
            // To read User Details
            string[] users = File.ReadAllLines("OnlineMedicalStore/UserDetails.csv");
            foreach(string user in users)
            {
                UserDetails user1 = new UserDetails(user);
                Operation.userDatailsList.Add(user1);
            }

            // To read Medicine Details
            string[] medicines = File.ReadAllLines("OnlineMedicalStore/MedicineDetails.csv");
            foreach(string medicine in medicines)
            {
                MedicineDetails medicine1 = new MedicineDetails(medicine);
                Operation.medcineList.Add(medicine1);
            }

            // To read Order Details
            string[] orders = File.ReadAllLines("OnlineMedicalStore/OrderDetails.csv");
            foreach(string order in orders)
            {
                OrderDetails order1 = new OrderDetails(order);
                Operation.orderList.Add(order1);
            }
        }
    }
}