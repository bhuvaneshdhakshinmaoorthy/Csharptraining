using System;

namespace PhaseIComplexAssignments4
{
    class  Program
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string resultstring = string.Empty;

            for(int i=0; i<inputString.Length; i++)
            {
                if( !resultstring.Contains(inputString[i]))
                {
                    resultstring += inputString[i];
                }
            
            Console.WriteLine(resultstring);

        }
    }
}