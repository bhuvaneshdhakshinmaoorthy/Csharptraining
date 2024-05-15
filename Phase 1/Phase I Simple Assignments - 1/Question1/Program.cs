using System;

namespace Question1
{
    class  Program
    {
        public static void Main(string[] args)
        {
            string value = Console.ReadLine();
            string values = value.Replace(" ", "");
            Console.WriteLine($"Modified string: {values.Trim()}");
            Console.WriteLine($"Modified string length: {values.Length}");
        }
    }
}