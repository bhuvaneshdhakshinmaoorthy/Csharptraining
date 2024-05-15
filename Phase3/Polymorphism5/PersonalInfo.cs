using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism5
{
    public abstract class PersonalInfo
    {
        public abstract string Name { get; set; }
        public abstract string FatherName { get; set; }
        public abstract long MobileNumber { get; set; }
        public abstract string Gender { get; set; }

        // public PersonalInfo(string name, string fatherName, long mobileNumber, string gender)
        // {
        //     Name = name;
        //     FatherName = fatherName;
        //     MobileNumber = mobileNumber;
        //     Gender = gender;
        // }
        public abstract string Display();
    }
}