using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("MetroCardManagement"))
            {
                Directory.CreateDirectory("MetroCardManagement");
                System.Console.WriteLine($"MetroCardManagement folder created");
            }
            else
            {
                System.Console.WriteLine("Folder Already Exists");
            }
            // For User Details
            if(!File.Exists("MetroCardManagement/UserDetails.csv"))
            {
                File.Create("MetroCardManagement/UserDetails.csv").Close();
                System.Console.WriteLine("User Details file created");
            }
            else
            {
                System.Console.WriteLine("File Already Exists");
            }
            // For Travel History Details
            if(!File.Exists("MetroCardManagement/TravelHistoryDetails.csv"))
            {
                File.Create("MetroCardManagement/TravelHistoryDetails.csv").Close();
                System.Console.WriteLine("Travel History Details file created");
            }
            else
            {
                System.Console.WriteLine("File Already Exists");
            }
            // For Ticket Fare Details
            if(!File.Exists("MetroCardManagement/TicketFareDetails.csv"))
            {
                File.Create("MetroCardManagement/TicketFareDetails.csv").Close();
                System.Console.WriteLine("Ticket Fare Details file created");
            }
            else
            {
                System.Console.WriteLine("File Already Exists");
            }
        }
        public static void WriteToCSV()
        {
            // Write to  Users Details File
            string[] users = new string[Operation.userList.Count];
            for (int i = 0; i < Operation.userList.Count; i++)
            {
                users[i] = Operation.userList[i].CardNumber + "," + Operation.userList[i].UserName+","+ Operation.userList[i].PhoneNumber+","+ Operation.userList[i].Balance;
            }
            File.WriteAllLines("MetroCardManagement/UserDetails.csv",users);

            // Write to Travel History Details File
            string[] travel = new string[Operation.travelHistoryList.Count];
            for (int i = 0; i < Operation.travelHistoryList.Count; i++)
            {
                travel[i] = Operation.travelHistoryList[i].TravelID+","+ Operation.travelHistoryList[i].CardNumber+","+Operation.travelHistoryList[i].FromLocation+","+ Operation.travelHistoryList[i].ToLocation+","+ Operation.travelHistoryList[i].Date+","+ Operation.travelHistoryList[i].TravelCost;
            }
            File.WriteAllLines("MetroCardManagement/TravelHistoryDetails.csv",travel);

            // Write to Ticket Fare Details File
            string[] ticket = new string[Operation.ticketfareList.Count];
            for (int i = 0; i < Operation.ticketfareList.Count; i++)
            {
                ticket[i] = Operation.ticketfareList[i].TicketID+","+ Operation.ticketfareList[i].FromLocation+","+ Operation.ticketfareList[i].ToLocation+","+ Operation.ticketfareList[i].TicketPrice;
            }
            File.WriteAllLines("MetroCardManagement/TicketFareDetails.csv",ticket);
            
        }

        public static void ReadFromCSV()
        {
            // Read User Datails File
            string[] users = File.ReadAllLines("MetroCardManagement/UserDetails.csv");
            foreach (string user in users)
            {
                UserDetails user1 = new UserDetails(user);
                Operation.userList.Add(user1);
            }

            // Read Travel History File
            string[] travels = File.ReadAllLines("MetroCardManagement/TravelHistoryDetails.csv");
            foreach (string travel in travels)
            {
                TravelHistory travel1 = new TravelHistory(travel);
                Operation.travelHistoryList.Add(travel1);
            }
            // Read Ticket Fare Details
            string[] tickets = File.ReadAllLines("MetroCardManagement/TicketFareDetails.csv");
            foreach (string ticket in tickets)
            {
                TicketFareDetails ticket1 = new TicketFareDetails(ticket);
                Operation.ticketfareList.Add(ticket1);
            }
        }
        
    }
}