using System;

namespace PhaseIMediumAssignmentsQuestion9
{
    class  Program
    {
        public static void Main(string[] args)
        {
            string line = Console.ReadLine();

            Console.WriteLine($"The number of Alphabets in the string is: {CountAlphabets(line)}");
            Console.WriteLine($"The number of Digits in the string is: {CountDigits(line)}");
            Console.WriteLine($"The number of Special characters in the string is: {CountSpecialChars(line)}");
        }

        static int CountAlphabets(string line)
        {
            int alphabets = 0;
            foreach(char i in line)
            {
                if( (i>='A' && i<='Z')  || (i>='a'&& i<='z'))
                {
                    alphabets++;
                }
            }
            return alphabets;
        }

        static int CountDigits(string line)
        {
            int numbers = 0;
            foreach(char i in line)
            {
                if( i>='0' && i<='9')
                {
                    numbers++;
                }
            }
            return numbers;
        }

        static int CountSpecialChars(string line)
        {
            int chars = 0;
            foreach(char i in line)
            {
                if( (i>='A' && i<='Z')  || (i>='a'&& i<='z'))
                {
                    
                }
                else if( i>='0' && i<='9')
                {
                    
                }
                else
                {
                    chars++;
                }
            }
            return chars;
        }
    }
}