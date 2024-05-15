using System;
namespace Sealed2;
class Program
{
    public static void Main(string[] args)
    {
        PatientInfo patient = new PatientInfo("Bhuvanesh","Dhakshinamoorthy",30,"Vellore","dizziness");
        System.Console.WriteLine(patient.DisplayInfo());
        DoctorInfo doctor = new DoctorInfo("Bharathi","Dhakshinamoorthy");
        System.Console.WriteLine(doctor.DisplayInfo());
    }
}