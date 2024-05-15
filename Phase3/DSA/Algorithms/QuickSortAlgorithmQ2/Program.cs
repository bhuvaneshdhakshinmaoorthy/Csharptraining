using System;

namespace QuickSortAlgorithmQ1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] array = {"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};
            System.Console.WriteLine("Unsorted Array:");
            foreach (string i in array)
            {
                System.Console.Write(i + " ");
            }

            QuickSort(array, 0, array.Length - 1);
            
            System.Console.WriteLine();
            System.Console.WriteLine("Sorted Array:");
            foreach (string i in array)
            {
                System.Console.Write(i + " ");
            }
        }
        private static void QuickSort(string[] array, int l, int r)
        {
            if (l < r)
            {
                var pi = Partion(array, l, r);
                QuickSort(array, l, pi - 1);
                QuickSort(array, pi + 1, r);
            }
        }
        private static int Partion(string[] array, int l, int r)
        {
            int index = l;
            string pivot = array[l];
            for (int i = l + 1; i <= r; i++)
            {
                int answer = array[i].CompareTo(pivot);
                if (answer<0)
                {
                    index++;
                    Swap(array, index, i);
                }
            }
            Swap(array, index, l);
            return index;
        }
        public static void Swap(string[] array, int i, int j)
        {
            string temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
