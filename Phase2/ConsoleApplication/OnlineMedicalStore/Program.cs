using System;

namespace OnlineMedicalStore;

class Program
{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        // Operation.AddDefaultData();
        FileHandling.ReadFromCSV();
        Operation.MainMenu();
        FileHandling.WriteToCSV();
    }
}