using System;

namespace BubbleAlgorithmQ3
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] value = new char[] {'c','a','f','b','k','h','z','t','m','p','l','d'};
            System.Console.WriteLine("Unsorted Array:");
            foreach (char i in value)
            {
                System.Console.Write(i + " ");
            }

            for (int i = 0; i < value.Length - 1; i++)
            {
                for (int j = 0; j < value.Length - 1; j++)
                {
                    if (value[j] > value[j + 1])
                    {
                        char temp = value[j];
                        value[j] = value[j + 1];
                        value[j + 1] = temp;
                    }
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Sorted Array:");
            foreach (char i in value)
            {
                System.Console.Write(i + " ");
            }

        }
    }
}