using System;
namespace Overloading;
class Program
{
    public static void Main(string[] args)
    {
        //  Overloading by number of arguments
        
        Add(10,20);
        Add(10,20,30);
        // Overloading by type
        Add("Ravi",40);
        Add(10.5,30)

        public static int Add(int number1,int number2)
        {
            return number1 + number2;
        }
        public static int Add(int number1,int number2,int number3)
        {
            return number1 + number2 + number3;
        }
        public static int Add(string name,int number1)
        {
            return name + number1;
        }
        public static int Add(double number1,int number2)
        {
            return number1 + number2;
        }

    }
}