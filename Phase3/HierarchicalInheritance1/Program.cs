using System;
using System.Runtime.InteropServices;
namespace HierarchicalInheritance1;
class Program
{
    public static void Main(string[] args)
    {
        TeacherInfo teacher1 = new TeacherInfo("Bradeesh","Moorthy",new DateTime(1970,10,10),9876543210,"Male","bradesh@gmail.com","Mech","FEA","MPhil",10,new DateTime(2012,10,10));
        System.Console.WriteLine(teacher1.ShowDetails());
        StudentInfo student1 = new StudentInfo("Bhuvanesh","Moorthy",new DateTime(2001,07,06),987654321,"Male","bhuvanesh@gmail.com","BE","Mech",8);
        System.Console.WriteLine(student1.ShowDetails());
        PrincipalInfo principal = new PrincipalInfo("Manonmani","Sundaram",new DateTime(1965,10,10),987654321,"Female","manonmai@gmail.com","Ph.D",20,new DateTime(2002,10,10));
        System.Console.WriteLine(principal.ShowDetails());
    }
}