using System;

namespace BubbleAlgorithmQ1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] value = new int[] { 45, 33, 12, 55, 77, 22, 33, 14, 12, 35};
            System.Console.WriteLine("Unsorted Array:");
            foreach (int i in value)
            {
                System.Console.Write(i + " ");
            }
            // bool flag = true;
            for (int i = 0; i < value.Length - 1; i++)
            {
                // flag = false;
                for (int j = 0; j < value.Length - 1; j++)
                {
                    if (value[j] > value[j + 1])
                    {
                        int temp = value[j];
                        value[j] = value[j + 1];
                        value[j + 1] = temp;
                        // flag = true;
                    }
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Sorted Array:");
            foreach (int i in value)
            {
                System.Console.Write(i + " ");
            }

        }
    }
}