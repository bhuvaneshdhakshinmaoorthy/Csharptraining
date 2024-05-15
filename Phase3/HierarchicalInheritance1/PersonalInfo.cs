using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance1
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public long Phone { get; set; }
        public string Gender { get; set; }
        public string Mail { get; set; }
        
        public PersonalInfo(string name, string fatherName,DateTime dob, long phone, string gender, string mail)
        {
            Name = name;
            FatherName =fatherName;
            DOB = dob;
            Phone = phone;
            Gender = gender;
            Mail = mail;
        }
    }
}