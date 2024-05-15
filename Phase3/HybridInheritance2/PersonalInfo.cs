using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritance2
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public long Phone { get; set; }
        public PersonalInfo(string name, string gender, DateTime dob, long phone)
        {
            Name = name;
            Gender = gender;
            DOB = dob;
            Phone = phone;
        }
    }
}