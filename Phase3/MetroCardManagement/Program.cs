using System;

namespace MetroCardManagement;
class Program
{
    public static void Main(string[] args)
    {
        // FileHandling.Create();
        // Operation.DefaultData();
        FileHandling.ReadFromCSV();
        Operation.MainMenu();
        FileHandling.WriteToCSV();
    }
}