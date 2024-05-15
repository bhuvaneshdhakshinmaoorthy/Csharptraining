using System;

namespace BubbleAlgorithmQ2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] value = {"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};
            System.Console.WriteLine("Unsorted Array:");
            foreach (string i in value)
            {
                System.Console.Write(i + " ");
            }

            for (int i = 0; i < value.Length - 1; i++)
            {
                for (int j = 0; j < value.Length - 1; j++)
                {
                    int answer = value[j].CompareTo(value[j + 1]);
                    if (answer==1)
                    {
                        string temp = value[j];
                        value[j] = value[j + 1];
                        value[j + 1] = temp;
                    }
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Sorted Array:");
            foreach (string i in value)
            {
                System.Console.Write(i + " ");
            }

        }
    }
}