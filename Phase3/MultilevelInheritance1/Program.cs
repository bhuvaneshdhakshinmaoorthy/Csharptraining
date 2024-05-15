using System;
namespace MultilevelInheritance1;
class Program
{
    public static void Main(string[] args)
    {
        // Create Instance For Last Inherited Class, Call method from that object
        
        HSCDetails student1 = new HSCDetails("Bhuvanesh","Dhaksinamoorthy",987654321,"bhuvanesh@gmail.com",new DateTime(2001,07,06),"Male",11,"ComputerScience","2023-2024",99,99,99);
        HSCDetails student2 = new HSCDetails("Bharathi","Dhaksinamoorthy",987654321,"bharathi@gmail.com",new DateTime(1997,07,10),"Female",11,"Bio-Science","2023-2024",99,99,99);
        student1.GetStudentInfo();
        System.Console.WriteLine(student1.ShowStudentInfo());
        student1.GetMarks();
        student1.Calculate();
        System.Console.WriteLine(student1.ShowMarkSheet());

        student2.GetStudentInfo();
        System.Console.WriteLine(student2.ShowStudentInfo());
        student2.GetMarks();
        student2.Calculate();
        System.Console.WriteLine(student2.ShowMarkSheet());
    }
}