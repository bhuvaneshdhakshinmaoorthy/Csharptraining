using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccination
{
    public enum VaccineName{Select,Covishield, Covaccine}
    public class VaccineDetails
    {
        // private static int s_vaccineID = 2000;
        // public string VaccineID { get; set; }
        public string VaccineID { get; set; }
        public VaccineName VaccineName { get; set; }
        public int NoOfDoseAvailable { get; set; }

        public VaccineDetails(string vaccineID,VaccineName vaccineName,int noOfDoseAvailable)
        {
            // s_vaccineID++;
            VaccineID = vaccineID;
            VaccineName = vaccineName;
            NoOfDoseAvailable = noOfDoseAvailable;
        }
    }
}