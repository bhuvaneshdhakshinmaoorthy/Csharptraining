using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class Doctor
    {
        private static int s_doctorID = 0;
        public string DoctorID { get; }
        public string DoctorName { get; set; }
        public string Department { get; set; }

        public Doctor(string name, string department)
        {
            s_doctorID++;
            DoctorID = "DID" + s_doctorID;
            DoctorName = name;
            Department = department;
        }

    }
}