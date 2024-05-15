using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace CovidVaccination
{
    public class Operation
    {
        static List<BenificiaryDetails> benificiaryList = new List<BenificiaryDetails>();
        static List<VaccineDetails> vaccineList = new List<VaccineDetails>();
        static List<VaccinationHistory> vaccinationHistoryList = new List<VaccinationHistory>();
        static BenificiaryDetails currentLoginBeneficiary;
        public static void AddDefaultData()
        {
            BenificiaryDetails benificiary1 = new BenificiaryDetails("Ravichandran", 21, Gender.Male, 8484848484, "Theni");
            BenificiaryDetails benificiary2 = new BenificiaryDetails("Baskaran", 22, Gender.Male, 8787878787, "Chennai");
            benificiaryList.Add(benificiary1);
            benificiaryList.Add(benificiary2);

            VaccineDetails vaccine1 = new VaccineDetails("CID2001", VaccineName.Covishield, 50);
            VaccineDetails vaccine2 = new VaccineDetails("CID2002", VaccineName.Covaccine, 50);
            vaccineList.Add(vaccine1);
            vaccineList.Add(vaccine2);

            VaccinationHistory vaccinated1 = new VaccinationHistory("BID1001", "CID2001", 1, new DateTime(2022, 11, 11));
            VaccinationHistory vaccinated2 = new VaccinationHistory("BID1001", "CID2001", 2, new DateTime(2023, 03, 11));
            VaccinationHistory vaccinated3 = new VaccinationHistory("BID1002", "CID2002", 1, new DateTime(2023, 04, 04));
            vaccinationHistoryList.Add(vaccinated1);
            vaccinationHistoryList.Add(vaccinated2);
            vaccinationHistoryList.Add(vaccinated3);

            foreach (BenificiaryDetails beneficiary in benificiaryList)
            {
                System.Console.WriteLine($"| {beneficiary.RegistrationNumber,-10} | {beneficiary.Name,-15} | {beneficiary.Age,-10} | {beneficiary.Gender,-10} | {beneficiary.MobileNumber,-10} | {beneficiary.City,-10} |");
            }
            foreach (VaccineDetails vaccine in vaccineList)
            {
                System.Console.WriteLine($"| {vaccine.VaccineID,-10} | {vaccine.VaccineName,-15} | {vaccine.NoOfDoseAvailable,-10} |");
            }
            foreach (VaccinationHistory vaccinated in vaccinationHistoryList)
            {
                System.Console.WriteLine($"| {vaccinated.VaccinationID,-10} | {vaccinated.RegistrationNumber,-10} | {vaccinated.VaccineID,-10} | {vaccinated.DoseNumber,-10} | {vaccinated.VaccinatedDate.ToString("dd/MM/yyyy"),-10} |");
            }
        }
        public static void MainMenu()
        {
            System.Console.WriteLine("Vaccination Drive");
            bool flag = true;
            do
            {
                System.Console.WriteLine("1.Benificiary Registration \n2.Login \n3.Get Vaccine Info \n4.Exit");
                int userDecision = int.Parse(Console.ReadLine());
                switch (userDecision)
                {
                    case 1:
                        {
                            BenificiaryRegistration();
                            break;
                        }
                    case 2:
                        {
                            Login();
                            break;
                        }
                    case 3:
                        {
                            GetVaccineInfo();
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
        public static void BenificiaryRegistration()
        {
            System.Console.WriteLine("Registration process selected");
            System.Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your gender: Male,Female,Others");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            System.Console.WriteLine("Enter your mobile number");
            long mobileNumber = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your city");
            string city = Console.ReadLine();

            BenificiaryDetails benificiary = new BenificiaryDetails(name, age, gender, mobileNumber, city);
            benificiaryList.Add(benificiary);
            System.Console.WriteLine($"Your registration is done. Your registration number {benificiary.RegistrationNumber}");
        }
        public static void Login()
        {
            System.Console.WriteLine("Login process selected");
            System.Console.WriteLine("Enter your register number");
            string checkRegisterNumber = Console.ReadLine().ToUpper();
            bool flag = false;
            foreach (BenificiaryDetails benificiary in benificiaryList)
            {
                if (checkRegisterNumber == benificiary.RegistrationNumber)
                {
                    flag = true;
                    System.Console.WriteLine("Login Successfull");
                    currentLoginBeneficiary = benificiary;
                    SubMenu();
                    break;
                }
            }
            if (!flag)
            {
                System.Console.WriteLine("Invalid Register Number");
            }
        }
        public static void GetVaccineInfo()
        {
            foreach (VaccineDetails vaccine in vaccineList)
            {
                System.Console.WriteLine($"| {vaccine.VaccineID,-10} | {vaccine.VaccineName,-15} | {vaccine.NoOfDoseAvailable,-10} |");
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("1.Show My Details \n2.Take Vaccination \n3.My Vaccination History \n4.Next Due Date \n5.Exit");
                int userDecision2 = int.Parse(Console.ReadLine());
                switch (userDecision2)
                {
                    case 1:
                        {
                            ShowMyDetails();
                            break;
                        }
                    case 2:
                        {
                            TakeVaccination();
                            break;
                        }
                    case 3:
                        {
                            MyVaccinationHistory();
                            break;
                        }
                    case 4:
                        {
                            NextEligibleDate();
                            break;
                        }
                    case 5:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void ShowMyDetails()
        {
            // bool equal = false;
            foreach (BenificiaryDetails beneficiary in benificiaryList)
            {
                if (currentLoginBeneficiary.RegistrationNumber == beneficiary.RegistrationNumber)
                {
                    // equal = true;
                    System.Console.WriteLine($"| {beneficiary.RegistrationNumber,-10} | {beneficiary.Name,-15} | {beneficiary.Age,-10} | {beneficiary.Gender,-10} | {beneficiary.MobileNumber,-10} | {beneficiary.City,-10} |");

                }
            }
            // if(!equal)
            // {
            //     Console.WriteLine("")
            // }
        }
        public static void TakeVaccination()
        {
            // Show the list of vaccine available and to select a vaccine.
            foreach (VaccineDetails vaccine in vaccineList)
            {
                System.Console.WriteLine($"| {vaccine.VaccineID,-10} | {vaccine.VaccineName,-15} | {vaccine.NoOfDoseAvailable,-10} |");
            }
            // Ask the user to select a vaccine by using vaccine ID and find the ID is valid.
            System.Console.WriteLine("Please select the vaccine, enter that vaccineID");
            string checkVaccineID = Console.ReadLine().ToUpper();

            bool checker = true;
            foreach (VaccineDetails vaccinecheck in vaccineList)
            {
                if (checkVaccineID == vaccinecheck.VaccineID)
                {
                    checker = false;
                    if (vaccinecheck.NoOfDoseAvailable > 0)
                    {
                        bool flag = true;
                        int maxDoseCount = 0;
                        DateTime lastVaccinatedDate = new DateTime();
                        foreach (VaccinationHistory vaccinated in vaccinationHistoryList)
                        {
                            // Then, get the vaccination history of current logged in beneficiary. 
                            if (currentLoginBeneficiary.RegistrationNumber == vaccinated.RegistrationNumber)
                            {
                                flag = false;
                                maxDoseCount = vaccinated.DoseNumber;
                                lastVaccinatedDate = vaccinated.VaccinatedDate;

                            }
                        }
                        if (flag)
                        {
                            // 	If he didn’t take any vaccine means check his age is above 14. 
                            // 	If yes, then allow him to take that vaccine.
                            if (currentLoginBeneficiary.Age > 14)
                            {
                                // Update the details in his vaccination history list
                                maxDoseCount = 1;
                                VaccinationHistory vaccination = new VaccinationHistory(currentLoginBeneficiary.RegistrationNumber, checkVaccineID, maxDoseCount, DateTime.Today);
                                vaccinationHistoryList.Add(vaccination);
                                // Deduct the count of vaccine available. 
                                foreach (VaccineDetails vacccine in vaccineList)
                                {
                                    if (checkVaccineID == vacccine.VaccineID)
                                    {
                                        vacccine.NoOfDoseAvailable -= 1;
                                        break;
                                    }
                                }
                                System.Console.WriteLine($"You are vaccinated Successfully. Your vaccinated ID is {vaccination.VaccinationID}. \nYour next eligible date is {DateTime.Today.AddDays(30).ToString("dd/MM/yyyy")}");
                            }
                        }
                        else
                        {
                            // If he took three vaccines means show “All the three Vaccination are completed, you cannot be vaccinated now”.
                            if (maxDoseCount == 3)
                            {
                                System.Console.WriteLine("All the three Vaccination are completed, you cannot be vaccinated now");
                            }
                            // If he took one or two vaccines in his vaccination history, then find that he had selected the same vaccine type now. 
                            else if (maxDoseCount == 1 || maxDoseCount == 2)
                            {
                                bool equal = true;
                                foreach (VaccinationHistory vaccination in vaccinationHistoryList)
                                {
                                    if (currentLoginBeneficiary.RegistrationNumber == vaccination.RegistrationNumber && checkVaccineID == vaccination.VaccineID)
                                    {
                                        equal = false;
                                    }
                                }

                                // If it is no, then show “You have selected different vaccine”. You can vaccine with “Covaccine / Covishield (His first / second dose vaccine type)”  take vaccination process again.  
                                if (equal)
                                {
                                    string getID = "";
                                    foreach (VaccinationHistory vacinated in vaccinationHistoryList)
                                    {
                                        if (currentLoginBeneficiary.RegistrationNumber == vacinated.RegistrationNumber)
                                        {
                                            getID = vacinated.VaccineID;

                                            foreach (VaccineDetails vaccine in vaccineList)
                                            {
                                                if (getID == vaccine.VaccineID)
                                                {
                                                    // string name = vaccine.VaccineName;
                                                    System.Console.WriteLine($"You have selected different vaccine. You can vaccine with {vaccine.VaccineName}");
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                    }
                                    // VaccineName name;
                                }
                                // If it is yes, then check date of his last vaccination and find whether 30 days have completed.
                                else
                                {
                                    if (lastVaccinatedDate.AddDays(30) < DateTime.Today)
                                    {
                                        // If it is yes, then allow him to take vaccination.
                                        // Add the details to his vaccination list 
                                        maxDoseCount += 1;
                                        VaccinationHistory vaccination1 = new VaccinationHistory(currentLoginBeneficiary.RegistrationNumber, checkVaccineID, maxDoseCount, DateTime.Today);
                                        vaccinationHistoryList.Add(vaccination1);
                                        // Deduct the count of vaccine available. 
                                        foreach (VaccineDetails vacccine in vaccineList)
                                        {
                                            if (checkVaccineID == vacccine.VaccineID)
                                            {
                                                vacccine.NoOfDoseAvailable -= 1;
                                                break;
                                            }
                                        }
                                        System.Console.WriteLine($"You are vaccinated Successfully. Your vaccinated ID is {vaccination1.VaccinationID}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"You are not eligible for vaccination. Your next eligible date is {lastVaccinatedDate.AddDays(30).ToString("dd/MM/yyyy")}");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vaccine Doses are not available");
                    }
                }
            }
            if (checker)
            {
                System.Console.WriteLine("Invalid VaccineID");
            }
            // else
            // {

            // }
        }
        public static void MyVaccinationHistory()
        {
            bool equal = false;
            foreach (VaccinationHistory vaccinated in vaccinationHistoryList)
            {
                if (currentLoginBeneficiary.RegistrationNumber == vaccinated.RegistrationNumber)
                {
                    equal = true;
                    System.Console.WriteLine($"| {vaccinated.VaccinationID,-10} | {vaccinated.RegistrationNumber,-10} | {vaccinated.VaccineID,-10} | {vaccinated.DoseNumber,-10} | {vaccinated.VaccinatedDate.ToString("dd/MM/yyyy"),-10} |");

                }
            }
            if (!equal)
            {
                System.Console.WriteLine("You didn't have any vacinated history");
            }
        }
        public static void NextEligibleDate()
        {
            bool flag = true;
            DateTime lastVaccinatedDate = new DateTime();
            int doseCount = 0;
            foreach (VaccinationHistory vaccination in vaccinationHistoryList)
            {
                if (currentLoginBeneficiary.RegistrationNumber == vaccination.RegistrationNumber)
                {
                    flag = false;
                    lastVaccinatedDate = vaccination.VaccinatedDate;
                    doseCount = vaccination.DoseNumber;
                }
            }
            if (flag)
            {
                System.Console.WriteLine("You can take vaccine now");
            }
            else
            {
                if (doseCount == 1 || doseCount == 2)
                {
                    System.Console.WriteLine($"Your next eligible date for vaccine is {lastVaccinatedDate.AddDays(30).ToString("dd/MM/yyyy")}");
                }
                else if (doseCount == 3)
                {
                    System.Console.WriteLine("You have completed all vaccination. Thanks for your participation in the vaccination drive.");
                }
            }
        }
    }
}