using System;

namespace HospitalManagement;

class Program
{
    public static void Main(string[] args)
    {
        AppointmentManager.DefaultData();
        AppointmentManager hospitalManagement = new AppointmentManager();
        hospitalManagement.MainMenu();
    }
}
