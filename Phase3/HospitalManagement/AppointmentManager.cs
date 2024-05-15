using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class AppointmentManager
    {
        static List<Doctor> doctorsList = new List<Doctor>();
        static List<Patient> patientsList = new List<Patient>();
        static List<Appointment> appointmentsList = new List<Appointment>();
        static Patient currentLoginPatient;

        // Declare Delegate
        public delegate void AppointmentBooked();
        // Declare Event
        public event AppointmentBooked AppointmentAdded;
        // Raise Event
        protected void OnAppointmentAdded() //protected virtual method
        {
            AppointmentAdded?.Invoke();
            System.Console.WriteLine("Appointment Added");
        }
        public static void DefaultData()
        {
            Doctor doctor1 = new Doctor("Nancy", "Anaesthesiology");
            Doctor doctor2 = new Doctor("Andrew", "Cardiology");
            Doctor doctor3 = new Doctor("Janet", "Diabetology");
            Doctor doctor4 = new Doctor("Margaret", "Neonatology");
            Doctor doctor5 = new Doctor("Steven", "Nephrology");
            doctorsList.Add(doctor1);
            doctorsList.Add(doctor2);
            doctorsList.Add(doctor3);
            doctorsList.Add(doctor4);
            doctorsList.Add(doctor5);
            Patient patient1 = new Patient("welcome", "Robert", 40, Gender.Male);
            Patient patient2 = new Patient("welcome", "Laura", 36, Gender.Female);
            Patient patient3 = new Patient("welcome", "Anne", 42, Gender.Female);
            patientsList.Add(patient1);
            patientsList.Add(patient2);
            patientsList.Add(patient3);
            Appointment appointment1 = new Appointment("PID101", "DID1", new DateTime(2012, 8, 3), "Heart problem");
            Appointment appointment2 = new Appointment("PID101", "DID5", new DateTime(2012, 8, 3), "Spinal cord injury");
            Appointment appointment3 = new Appointment("PID102", "DID2", new DateTime(2012, 8, 3), "Heart attack");
            appointmentsList.Add(appointment1);
            appointmentsList.Add(appointment2);
            appointmentsList.Add(appointment3);
            foreach (Doctor doctor in doctorsList)
            {
                System.Console.WriteLine($"| {doctor.DoctorID,-5} | {doctor.DoctorName,-15} | {doctor.Department,-15} |");
            }
            foreach (Patient patient in patientsList)
            {
                System.Console.WriteLine($"| {patient.PatientID,-7} | {patient.Password,-10} | {patient.Name,-10} | {patient.Age,-5} | {patient.Gender,-8} |");
            }
            foreach (Appointment appointment in appointmentsList)
            {
                System.Console.WriteLine($"| {appointment.AppointmentID,-5} | {appointment.PatientID,-5} | {appointment.DoctorID,-5} | {appointment.Date.ToString("MM/dd/yyyy"),-10} | {appointment.Problem,-20} |");
            }
        }
        public void MainMenu()
        {
            System.Console.WriteLine("Welcome to Sync Hospital");
            bool flag = true;
            do
            {
                System.Console.WriteLine("1.Login \n2.Register \n3.Exit \nEnter the number to select the option");
                int userDecision = int.Parse(Console.ReadLine());
                switch (userDecision)
                {
                    case 1:
                        {
                            Login();
                            break;
                        }
                    case 2:
                        {
                            Register();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Exit Selected. \nThank You!!!");
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public void Login()
        {
            System.Console.WriteLine("Login Option Selected \nEnter your name");
            string userName = Console.ReadLine();
            System.Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            bool flag = true;
            foreach (Patient patient in patientsList)
            {
                if (patient.Name == userName && patient.Password == password)
                {
                    flag = false;
                    System.Console.WriteLine("Logined Successfully.");
                    currentLoginPatient = patient;
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                System.Console.WriteLine("Sorry, your record is invalid. Please register your profile and login again");
            }
        }
        public static void Register()
        {
            System.Console.WriteLine("Register Option Selected \nEnter your name");
            string userName = Console.ReadLine();
            System.Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            System.Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your gender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            Patient patient = new Patient(password, userName, age, gender);
            patientsList.Add(patient);
            System.Console.WriteLine($"Your registration is done. Your ID is {patient.PatientID}");
        }
        public void SubMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("1.Book Appointment \n2.View Appointment details \n3.Edit my profile \n4.Exit \nEnter the number to select the option");
                int userDecision2 = int.Parse(Console.ReadLine());
                switch (userDecision2)
                {
                    case 1:
                        {
                            BookAppointment();
                            break;
                        }
                    case 2:
                        {
                            ViewAppointmentDetails();
                            break;
                        }
                    case 3:
                        {
                            EditMyProfile();
                            break;
                        }
                    case 4:
                        {
                            flag = false;
                            break;
                        }
                }

            } while (flag);
        }
        public void BookAppointment()
        {
            foreach (Doctor doctor in doctorsList)
            {
                System.Console.WriteLine($"| {doctor.Department,-15} |");
            }
            System.Console.WriteLine("Enter the Department");
            string checkDepartment = Console.ReadLine();

            bool flag = true;
            foreach (Doctor doctor in doctorsList)
            {
                if (doctor.Department == checkDepartment)
                {
                    flag = false;
                    System.Console.WriteLine("Enter your problem");
                    string problem = Console.ReadLine();
                    System.Console.WriteLine("Enter the date to book the appointment");
                    DateTime appointmentDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);
                    if (appointmentDate >= DateTime.Today)
                    {
                        int count = 0;
                        foreach (Appointment appointment in appointmentsList)
                        {
                            if (doctor.DoctorID == appointment.DoctorID && appointment.Date == appointmentDate)
                            {
                                count++;
                            }
                        }
                        if (count < 2)
                        {
                            System.Console.WriteLine($"Appointment is confirmed for the date: {appointmentDate.ToString("MM/dd/yyyy")}");
                            System.Console.WriteLine("To book confirm, enter yes or no");
                            string check = Console.ReadLine().ToUpper();
                            if (check == "YES")
                            {
                                Appointment appointment = new Appointment(currentLoginPatient.PatientID, doctor.DoctorID, appointmentDate, problem);
                                appointmentsList.Add(appointment);
                                OnAppointmentAdded();
                            }
                            else
                            {
                                System.Console.WriteLine("Exiting Without book an appointment");
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("Appointment is full for that day");
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("Invalid Date");
                    }

                }
            }
            if (flag)
            {
                System.Console.WriteLine("Invalid Department");
            }
        }
        public static void ViewAppointmentDetails()
        {
            bool flag = true;
            foreach (Appointment appointment in appointmentsList)
            {
                if (currentLoginPatient.PatientID == appointment.PatientID)
                {
                    flag = false;
                    System.Console.WriteLine($"| {appointment.AppointmentID,-5} | {appointment.PatientID,-5} | {appointment.DoctorID,-5} | {appointment.Date.ToString("MM/dd/yyyy"),-10} | {appointment.Problem,-20} |");
                }
            }
            if (flag)
            {
                System.Console.WriteLine("You don't have any history");
            }
        }
        public static void EditMyProfile()
        {
            foreach (Patient patient in patientsList)
            {
                if (currentLoginPatient.PatientID == patient.PatientID)
                {
                    System.Console.WriteLine("1.Name \n2.Password \n3.Age \n4.Gender \n5.Exit \nEnter the number to select the option");
                    int userDecision3 = int.Parse(Console.ReadLine());
                    switch (userDecision3)
                    {
                        case 1:
                            {
                                Name();
                                break;
                            }
                        case 2:
                            {
                                Password();
                                break;
                            }
                        case 3:
                            {
                                Age();
                                break;
                            }
                        case 4:
                            {
                                GenderChange();
                                break;
                            }
                    }
                }
            }

        }
        public static void Name()
        {
            System.Console.WriteLine("Enter the new name to change");
            string name = Console.ReadLine();
            currentLoginPatient.Name = name;
            System.Console.WriteLine($"Name changed Successfully as {currentLoginPatient.Name}");
        }
        public static void Password()
        {
            System.Console.WriteLine("Enter the new password to change");
            string password = Console.ReadLine();
            currentLoginPatient.Password = password;
            System.Console.WriteLine($"Name changed Successfully as {currentLoginPatient.Password}");
        }
        public static void Age()
        {
            System.Console.WriteLine("Enter the new age to change");
            int age = int.Parse(Console.ReadLine());
            currentLoginPatient.Age = age;
            System.Console.WriteLine($"Name changed Successfully as {currentLoginPatient.Age}");
        }
        public static void GenderChange()
        {
            System.Console.WriteLine("Enter the new gender to change");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            currentLoginPatient.Gender = gender;
            System.Console.WriteLine($"Name changed Successfully as {currentLoginPatient.Gender}");
        }

    }
}
