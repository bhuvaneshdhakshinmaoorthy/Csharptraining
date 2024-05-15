using System;

namespace SelectionAlgorithmQ1
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

            int index = 0;
            int mini = 0;
            int count = value.Length;
            while(index<count)
            {
                mini = index;
                for(int i=index+1; i<count; i++)
                {
                    if(value[i]<value[mini])
                    {
                        mini = i;
                    }
                }
                int temp = value[index];
                value[index] = value[mini];
                value[mini] = temp;
                index++;
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