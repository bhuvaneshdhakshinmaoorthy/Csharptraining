using System;

namespace PhaseIComplexAssignments3
{
    class  Program
    {
        public static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();

            string name1l = name1.ToLower();
            string name2l = name2.ToLower();

            char[] first1 = name1l.ToCharArray();
            char[] first2 = name2l.ToCharArray();

            Array.Sort(first1);
            Array.Sort(first2);

            string final1 = new string(first1);
            string final2 = new string(first2);

            if(final1 == final2)
            {
                Console.WriteLine("Anagrams");
            }
            else 
            {
                Console.WriteLine("Not Anagrams");
            }            
        }
    }
}