using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritance2
{
    public class IDInfo : PersonalInfo
    {
        public string VoterID { get; set; }
        public string AadharID { get; set; }
        public string PAN { get; set; }
        public IDInfo(string name, string gender, DateTime dob, long phone, string voterID, string aadharID, string pan) : base(name, gender, dob, phone)
        {
            VoterID = voterID;
            AadharID = aadharID;
            PAN = pan;
        }

        
    }
}