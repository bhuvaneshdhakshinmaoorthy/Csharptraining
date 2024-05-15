using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed3
{
    public class FamilyInfo : PersonalInfo
    {
        public string MotherName { get; set; }
        public int NoOfSibilings { get; set; }
        public string NativePlace { get; set; }

        public FamilyInfo(string motherName, int noOfSibilings, string nativePlace)
        {
            MotherName = motherName;
            NoOfSibilings = noOfSibilings;
            NativePlace = nativePlace;
        }

        public sealed override void Update()
        {
            
        }
        public void DisplayInfo()
        {
            
        }
    }
}