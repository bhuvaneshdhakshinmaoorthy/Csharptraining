using System;

namespace QuickSortAlgorithmQ1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 45, 33, 12, 55, 77, 22, 33, 14, 12, 35 };
            System.Console.WriteLine("Unsorted Array:");
            foreach (int i in array)
            {
                System.Console.Write(i + " ");
            }

            QuickSort(array, 0, array.Length-1);
            
            System.Console.WriteLine();
            System.Console.WriteLine("Sorted Array:");
            foreach (int i in array)
            {
                System.Console.Write(i + " ");
            }
        }
        private static void QuickSort(int[] array, int l, int r)
        {
            if (l < r)
            {
                var pi = Partion(array, l, r);
                QuickSort(array, l, pi - 1);
                QuickSort(array, pi + 1, r);
            }
        }
        private static int Partion(int[] array, int l, int r)
        {
            int index = l;
            int pivot = array[l];
            for (int i = l + 1; i <= r; i++)
            {
                if (array[i] < pivot)
                {
                    index++;
                    Swap(array, index, i);
                }
            }
            Swap(array, index, l);
            return index;
        }
        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
