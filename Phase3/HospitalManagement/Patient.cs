using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public enum Gender {Default,Male,Female}
    public class Patient
    {
        private static int s_patientID = 100;
        public string PatientID { get; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public Patient(string password, string patientName,  int patientAge, Gender gender)
        {
            s_patientID++;
            PatientID = "PID" + s_patientID;
            Name = patientName;
            Password = password;
            Age = patientAge;
            Gender = gender;
        }
    }
}