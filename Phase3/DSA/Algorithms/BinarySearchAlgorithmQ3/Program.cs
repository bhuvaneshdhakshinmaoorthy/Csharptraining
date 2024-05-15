using System;

namespace BinarySearchAlgorithmQ3
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
            int position = BinarySearch(values,searchElement);
            if(position>-1)
            {
                System.Console.WriteLine($"{searchElement} found at the index of {position} in the sorted array");
            }
            else
            {
                System.Console.WriteLine("Element not found");
            }
        }
        static int BinarySearch(char[] values, char searchElement)
        {
            int left = 0;
            int right = values.Length-1;
            while(left<=right)
            {
                int mid = left + (right - left)/2;
                if(values[mid]==searchElement)
                {
                    return mid;
                }
                else if(values[mid]<searchElement)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}