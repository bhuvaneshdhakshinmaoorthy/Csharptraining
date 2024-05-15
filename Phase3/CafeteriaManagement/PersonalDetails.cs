using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement 
{
    public enum Gender{Select,Male,Female,Others}
    public class PersonalDetails 
    {
        public string Name { get; set; }
        public string FatherName { get; set; }        
        public long MobileNumber { get; set; }
        public string MailID { get; set; }
        public  Gender Gender { get; set; }

        public PersonalDetails(string name, string fatherName,long mobileNumber, string mailID, Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            MobileNumber = mobileNumber;
            MailID = mailID;
            Gender = gender;
        }
        public PersonalDetails(string user)
        {
            
        }
        
    }
}