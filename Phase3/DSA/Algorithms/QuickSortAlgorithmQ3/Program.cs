using System;

namespace QuickSortAlgorithmQ1
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] array = new char[] {'c','a','f','b','k','h','z','t','m','p','l','d'};
            System.Console.WriteLine("Unsorted Array:");
            foreach (char i in array)
            {
                System.Console.Write(i + " ");
            }

            QuickSort(array, 0, array.Length - 1);
            
            System.Console.WriteLine();
            System.Console.WriteLine("Sorted Array:");
            foreach (char i in array)
            {
                System.Console.Write(i + " ");
            }
        }
        private static void QuickSort(char[] array, int l, int r)
        {
            if (l < r)
            {
                var pi = Partion(array, l, r);
                QuickSort(array, l, pi - 1);
                QuickSort(array, pi + 1, r);
            }
        }
        private static int Partion(char[] array, int l, int r)
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
        public static void Swap(char[] array, int i, int j)
        {
            char temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
