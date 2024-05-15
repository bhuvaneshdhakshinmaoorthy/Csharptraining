using System;

namespace BinarySearchAlgorithmQ1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] values = new int[]{45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
            Array.Sort(values);
            foreach(int i in values)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
            int searchElement = 66;
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
        static int BinarySearch(int[] values,string checkUserID)
        {
            int left = 0;
            int right = values.Length-1;
            while(left<=right)
            {
                int mid = left + (right - left)/2 ;
                if(values[mid]==checkUserID)
                {
                    return mid;
                }
                else if()
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
