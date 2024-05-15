using System;

namespace SelectionAlgorithmQ3
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] value = new char[] {'c','a','f','b','k','h','z','t','m','p','l','d'};
            System.Console.WriteLine("Unsorted Array:");
            foreach (char i in value)
            {
                System.Console.Write(i + " ");
            }

            int index = 0;
            int minPosition = 0;
            int count = value.Length;
            while(index<count)
            {
                minPosition = index;
                for(int i=index+1; i<count; i++)
                {
                    if(value[i]<value[minPosition])
                    {
                        minPosition = i;
                    }
                }
                char temp = value[index];
                value[index] = value[minPosition];
                value[minPosition] = temp;
                index++;
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine("Sorted Array:");
            foreach (char i in value)
            {
                System.Console.Write(i + " ");
            }

        }
    }
}