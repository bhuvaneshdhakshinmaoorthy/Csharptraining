using System;

namespace LinearSearchAlgorithmQ3
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] values = new char[]{'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d'};
            Array.Sort(values);
            foreach(char i in values)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
            char searchElement = 'm';
            System.Console.WriteLine($"Need to find the index position of {searchElement}");
            int position = LinearSearch(values,searchElement);
            if(position>-1)
            {
                System.Console.WriteLine($"{searchElement} found at the index of {position} in the sorted array");
            }
            else
            {
                System.Console.WriteLine("Element not found");
            }
        }
        static int LinearSearch(char[] values, int searchElement)
        {
            int position = -1;
            for (var i = 0; i < values.Length; i++)
            {
                if (values[i] == searchElement)
                {
                    position = i;
                    break;
                }
            }
            return position;
        }
    }
}