﻿using System;

namespace LinearSearchAlgorithmQ1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] values = new int[] { 45, 33, 12, 55, 77, 22, 33, 14, 67, 78, 22, 11, 44, 66, 88, 12, 35, 84, 93, 77 };
            foreach (int i in values)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
            int searchElement = 66;
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
        static int LinearSearch(int[] values, int searchElement)
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