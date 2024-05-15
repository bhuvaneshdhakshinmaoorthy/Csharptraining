using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed1
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Mobile { get; set; }
        public string Mail { get; set; }
        public string Gender { get; set; }

        public PersonalInfo(string name, string fatherName, long mobile, string mail, string gender)
        {
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            Mail = mail;
            Gender = gender;
        }
        public void UpdateInfo()
        {

        }
    }
}