using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance1
{
    public class PersonalInfo : IShowData
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public long Phone { get; set; }
        public string MarriedDetails { get; set; }

        public PersonalInfo(string name, string gender, DateTime dob,long phone, string marriedDetails)
        {
            Name = name;
            Gender = gender;
            DOB = dob;
            Phone = phone;
            MarriedDetails = marriedDetails;
        }
        
        public void ShowInfo()
        {
            
        }
    }
}