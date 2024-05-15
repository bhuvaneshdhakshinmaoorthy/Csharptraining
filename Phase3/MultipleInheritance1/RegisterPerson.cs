using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance1
{
    public class RegisterPerson : PersonalInfo, IShowData, IFamilyInfo
    {
        private int _registrationNumber = 1000;
        public string RegistrationNumber { get; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSiblings { get; set; }

        public RegisterPerson(string name, string gender, DateTime dob,long phone, string marriedDetails,string fatherName, string motherName, string houseAddress, int noOfSiblings):base(name, gender, dob, phone, marriedDetails)
        {
            _registrationNumber++;
            RegistrationNumber = "REG" + _registrationNumber;
            // Name = name;
            // Gender = gender;
            // DOB = dob;
            // Phone = phone;
            // MarriedDetails = marriedDetails;
            FatherName = fatherName;
            MotherName = motherName;
            HouseAddress = houseAddress;
            NoOfSiblings = noOfSiblings;
        }
        public new string ShowInfo()
        {
            return ($"{RegistrationNumber} {DateTime.Today.ToString("dd/MM/yyyy")} {Name} {Gender} {DOB.ToString("dd/MM/yyyy")} {Phone} {MarriedDetails} {FatherName} {MotherName} {HouseAddress} {NoOfSiblings}");
        }
    }
}