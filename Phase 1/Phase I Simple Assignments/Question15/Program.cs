using System;

namespace Question15
{
    class  Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.Write(Greetings1(name));
            Console.Write(Greetings2(name));
        }

        static string Greetings1(string name)
        {
            string first = $"Welcome {name}. ";
            return first;
        }

        static string Greetings2(string name)
        {
            string second = "Have a nice day!";
            return second;
        }
    }
}