using System;

namespace LinearSearchAlgorithmQ1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] values = new string[]{"SF3023", "SF3021", "SF3067", "SF3043","SF3053", "SF3032", "SF3063", "SF3089","SF3062", "SF3092"};
            foreach (string i in values)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
            string searchElement = "SF3067";
            System.Console.WriteLine($"Need to find the index position of {searchElement}");
            int position = LinearSearch(values, searchElement);
            if (position > -1)
            {
                System.Console.WriteLine($"{searchElement} found at the index of {position} in the array");
            }
            else
            {
                System.Console.WriteLine("Element not found");
            }
        }
        static int LinearSearch(string[] values, string searchElement)
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