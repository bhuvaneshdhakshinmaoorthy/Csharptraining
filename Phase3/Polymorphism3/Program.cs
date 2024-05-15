using System;

namespace Polymorphism3;
class Program
{
    public static void Main(string[] args)
    {
        // EEEDepartment eee = new EEEDepartment("Vijay","Semi-Conducttors","Rajan",2019);
        
        // CSEDepartment cse = new CSEDepartment("Bhuvanesh","Python","Bharathi",2020);
        // System.Console.WriteLine(cse.DisplayInfo());
        // CSEDepartment cse1 = new CSEDepartment("Bhuvanesh","Python","Bharathi",2020);
        // System.Console.WriteLine(cse1.DisplayInfo());

        EEEDepartment lib3 = new EEEDepartment("Vijay","Semi-Conducttors","Rajan",2019);
        EEEDepartment lib4 = new EEEDepartment("Bharathi","Matlab","Ravi",2000);
        CSEDepartment lib1 = new CSEDepartment("Bhuvanesh","Python","Bharathi",2020);
        CSEDepartment lib2 = new CSEDepartment("Shibu","Python","Bharathi",2020);
        System.Console.WriteLine(lib1.DisplayInfo());
        System.Console.WriteLine(lib2.DisplayInfo());
        System.Console.WriteLine(lib3.DisplayInfo());
        System.Console.WriteLine(lib4.DisplayInfo());
    }
}