using System;

namespace BinarySearchAlgorithmQ2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] values = new string[]{"SF3023", "SF3021", "SF3067", "SF3043","SF3053", "SF3032", "SF3063", "SF3089","SF3062", "SF3092"};
            Array.Sort(values);
            foreach(string i in values)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
            string searchElement = "SF3067";
            System.Console.WriteLine($"Need to find the index position of the {searchElement} in the sorted array");
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
        static int BinarySearch(string[] values, string searchElement)
        {
            int left = 0;
            int right = values.Length-1;
            while(left<=right)
            {
                int mid = left + (right - left)/2;
                int answer = searchElement.CompareTo(values[mid]);
                if(answer==0)
                {
                    return mid;
                }

                else if (answer==1)
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