using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed2
{
    public class DoctorInfo : PatientInfo
    {
        private int _doctorID = 4000;
        public string DoctorID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; }

        public DoctorInfo(string name, string fatherName)
        {
            _doctorID++;
            DoctorID = "DID" + _doctorID;
            Name = name;
            FatherName = fatherName;
        }
        public string DisplayInfo()
        {
            return $"{DoctorID} {Name} {FatherName}";
        }
    }
}