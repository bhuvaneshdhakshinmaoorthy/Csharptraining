using System;

namespace SelectionAlgorithmQ1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] value = {"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};
            System.Console.WriteLine("Unsorted Array:");
            foreach (string i in value)
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
                    int answer = value[i].CompareTo(value[mini]);
                    if(answer<0)
                    {
                        mini = i;
                    }
                }
                string temp = value[index];
                value[index] = value[mini];
                value[mini] = temp;
                index++;
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine("Sorted Array:");
            foreach (string i in value)
            {
                System.Console.Write(i + " ");
            }

        }
    }
}