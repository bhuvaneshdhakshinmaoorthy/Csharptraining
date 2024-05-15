using System;
namespace Interface
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMarkDetails obj = new IMarkDetails();
            StudentDetails student = new StudentDetails(50,50,50);

            IMarkDetails mark = new StudentDetails(10,10,10);
            System.Console.WriteLine(mark.Mark1 + " " + mark.Mark2);

            IMarkDetails markSheet1 = new StudentDetails(20,21,22);
            List<IMarkDetails> markDetails = new List<IMarkDetails>();
            markDetails.Add(student);
            markDetails.Add(mark);
            markDetails.Add(markSheet1);

            // Polymorphism 
        }
    }
}