using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class Appointment
    {
        private static int s_appointmentID = 1000;
        public string AppointmentID { get; }
        public string PatientID { get; set; }
        public string DoctorID { get; set; }
        public DateTime Date { get; set; }
        public string Problem { get; set; }
        public Appointment(string patientID, string doctorID, DateTime date, string problem)
        {
            s_appointmentID++;
            AppointmentID = "AID" + s_appointmentID;
            PatientID = patientID;
            DoctorID = doctorID;
            Date = date;
            Problem = problem;
        }
    }
}