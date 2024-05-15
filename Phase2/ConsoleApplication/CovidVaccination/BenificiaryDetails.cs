using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccination
{
    public enum Gender{Select,Male,Female,Others}
    public class BenificiaryDetails
    {
        private static int s_registrationNumber = 1000;
        public string RegistrationNumber { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public long MobileNumber { get; set; }
        public string City { get; set; }

        public BenificiaryDetails(string name, int age, Gender gender, long mobileNumber, string city)
        {
            s_registrationNumber++;
            RegistrationNumber = "BID" + s_registrationNumber;
            Name = name;
            Age = age;
            Gender = gender;
            MobileNumber = mobileNumber;
            City = city;
        }
    }
}