using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement
{
    public class Operation
    {
        static List<UserRegistration> userList = new List<UserRegistration>();
        static List<DonationDetails> donationList = new List<DonationDetails>();
        static UserRegistration currentLoginUser;
        public static void AddDefaultData()
        {
            UserRegistration user1 = new UserRegistration("Ravichandran", 8484848484, BloodGroup.O_Positive, 30, new DateTime(2022, 08, 25));
            UserRegistration user2 = new UserRegistration("Baskaran", 4747474747, BloodGroup.AB_Positive, 30, new DateTime(2022, 09, 30));
            userList.Add(user1);
            userList.Add(user2);
            DonationDetails donation1 = new DonationDetails("UID1001", new DateTime(2022, 06, 10), 73, 120, 14, BloodGroup.O_Positive);
            DonationDetails donation2 = new DonationDetails("UID1001", new DateTime(2022, 10, 10), 74, 120, 14, BloodGroup.O_Positive);
            DonationDetails donation3 = new DonationDetails("UID1002", new DateTime(2022, 07, 11), 74, 120, 13.6, BloodGroup.AB_Positive);
            donationList.Add(donation1);
            donationList.Add(donation2);
            donationList.Add(donation3);
            foreach (UserRegistration user in userList)
            {
                Console.WriteLine($"| {user.DonorID,-10} | {user.DonorName,-15} | {user.MobileNumber,-10} | {user.BloodGroup,-15} | {user.Age,-5} | {user.LastDonationDate.ToString("dd/MM/yyyy"),-15} |");
            }
            foreach (DonationDetails donation in donationList)
            {
                Console.WriteLine($"| {donation.DonationID,-10} | {donation.DonorID,-10} | {donation.DonationDate.ToString("dd/MM/yyyy"),-10} | {donation.Weight,-10} | {donation.BloodPressure,-10} | {donation.HemoglobinCount,-10} |  {donation.BloodGroup,-15} |");
            }
        }
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to Blood Bank");
            bool flag = true;
            do
            {
                Console.WriteLine($"1.User Registration \n2.User Login \n3.Fetch Donor Details \n4.Exit");
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
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            FetchDonorDetails();
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
        public static void Registration()
        {
            Console.WriteLine("Registration Process");
            Console.WriteLine("Enter your Name");
            string donorName = Console.ReadLine();
            Console.WriteLine("Enter your Mobile Number");
            long mobileNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Blood Group: A_Positive, B_Positive, O_Positive, AB_Positive");
            BloodGroup bloodGroup = Enum.Parse<BloodGroup>(Console.ReadLine(), true);
            Console.WriteLine("Enter your Age");
            int age = int.Parse(Console.ReadLine());
            
            DateTime lastDonationDate = new DateTime();
            if (age >= 18)
            {
                Console.WriteLine("Did you donated the blood already?: yes or no");
                string userAnswer = Console.ReadLine().ToUpper();             
                if (userAnswer == "YES")
                {
                    Console.WriteLine("Enter your last blood donated date");
                    lastDonationDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                }
            }
            UserRegistration user = new UserRegistration(donorName, mobileNumber, bloodGroup, age, lastDonationDate);
            userList.Add(user);
            Console.WriteLine($"Your registration was  done successfully. \nYour Donor ID is {user.DonorID}");
            // Console.WriteLine($"| {user.DonorID,-10} | {user.DonorName,-15} | {user.MobileNumber,-10} | {user.BloodGroup,-15} | {user.Age,-5} | {user.LastDonationDate.ToString("dd/MM/yyyy"),-15} |");

        }
        public static void UserLogin()
        {
            Console.WriteLine("Enter your DonorID");
            string checkDonorID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (UserRegistration user in userList)
            {
                if (checkDonorID == user.DonorID)
                {
                    flag = false;
                    currentLoginUser = user;
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid Donor ID");
            }
        }
        public static void FetchDonorDetails()
        {
            Console.WriteLine("To Fetch the Donor details");
            Console.WriteLine("Enter the required blood group");
            BloodGroup requiredBloodGroup = Enum.Parse<BloodGroup>(Console.ReadLine(), true);
            foreach (UserRegistration user in userList)
            {
                if (requiredBloodGroup == user.BloodGroup)
                {
                    Console.WriteLine($"| {user.DonorID,-10} | {user.DonorName,-15} | {user.MobileNumber,-10} | {user.BloodGroup,-15} | {user.Age,-5} | {user.LastDonationDate.ToString("dd/MM/yyyy"),-15} |");

                }
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("1.Donate Blood \n2.Donate History \n3.Next Eligible Date \n4.Exit");
                int userDecision2 = int.Parse(Console.ReadLine());
                switch (userDecision2)
                {
                    case 1:
                        {
                            DonateBlood();
                            break;
                        }
                    case 2:
                        {
                            DonateHistory();
                            break;
                        }
                    case 3:
                        {
                            NextEligibleDate();
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
        public static void DonateBlood()
        {
            if (currentLoginUser.Age >= 18)
            {
                DateTime eligible = new DateTime();
                foreach (DonationDetails donate in donationList)
                {
                    if (currentLoginUser.DonorID == donate.DonorID && donate.DonationDate > eligible)
                    {
                        eligible = donate.DonationDate;
                    }
                }
                // DateTime check = recentlyDonated.DonationDate.AddMonths(6);
                // Check whether the person’s completed 6 months after donating the blood.
                if (eligible.AddMonths(6) < DateTime.Today)
                {
                    //1. Get the weight, blood pressure, hemoglobin count from the user check Weight is above 50, bp is below 130 hemoglobin count is above 13.
                    Console.WriteLine("Enter your weight");
                    double weight = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your blood pressure");
                    double bloodPressure = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your Hemoglobin Count");
                    double hemoglobinCount = double.Parse(Console.ReadLine());
                    if (weight > 50 && bloodPressure < 130 && hemoglobinCount > 13.5)
                    {
                        // If both the conditions met, then add the details to the “Donation Details” object and finally add to the list.
                        DonationDetails donation = new DonationDetails(currentLoginUser.DonorID, DateTime.Today, weight, bloodPressure, hemoglobinCount, currentLoginUser.BloodGroup);
                        donationList.Add(donation);
                        // Finally show Blood donated successfully, Show the donation ID And print the next eligible date of donation.
                        // Next eligible date of donation is after 6 months from last time donor donate the blood.
                        Console.WriteLine($"Blood donated successfully. Your donation ID is {donation.DonationID} \nYour next eligible date of blood donation is {DateTime.Today.AddMonths(6).ToString("dd/MM/yyyy")}");

                    }
                    else
                    {
                        Console.WriteLine("Your body conditions not met for blood donation");
                    }
                }
                else
                {
                    Console.WriteLine($"You are not eligible for blood donation. Your next eligible date of blood donation is {eligible.AddMonths(6).ToString("dd/MM/yyyy")}");
                }
            }
            else
            {
                Console.WriteLine("Your age is below 18. So, you are not eligible for blood donation");
            }
        }
        public static void DonateHistory()
        {
            bool flag = true;
            foreach (DonationDetails donation in donationList)
            {
                if (currentLoginUser.DonorID == donation.DonorID)
                {
                    flag = false;
                    Console.WriteLine($"| {donation.DonationID,-10} | {donation.DonorID,-10} | {donation.DonationDate.ToString("dd/MM/yyyy"),-10} | {donation.Weight,-10} | {donation.BloodPressure,-10} | {donation.HemoglobinCount,-10} |  {donation.BloodGroup,-15} |");
                }

            }
            if (flag)
            {
                Console.WriteLine("You don't have any blood donate history");
            }
        }
        public static void NextEligibleDate()
        {
            bool equal = true;
            DateTime nextEligibleDate = new DateTime();
            foreach (DonationDetails donate in donationList)
            {
                if (currentLoginUser.DonorID == donate.DonorID && donate.DonationDate > nextEligibleDate)
                {
                    equal = false;
                    nextEligibleDate = donate.DonationDate;
                }
            }
            if (equal)
            {
                Console.WriteLine($"You didn't donate blood");
            }
            else
            {
                Console.WriteLine($"Your next eligible date of blood donation is {nextEligibleDate.AddMonths(6).ToString("dd/MM/yyyy")}");
            }


        }
    }
}