using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritance1
{
    public class PersonalInfo
    {
         private int _registrationNumber = 1000;
        public string RegistrationNumber { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }

        public PersonalInfo(string name, string fatherName, long phone, DateTime dob, string gender)
        {
            _registrationNumber++;
            RegistrationNumber = "SID" + _registrationNumber;
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            DOB = dob;
            Gender = gender;
        }
    }
}