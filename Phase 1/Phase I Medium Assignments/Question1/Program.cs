using System;

namespace Question1
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int basicSalary = int.Parse(Console.ReadLine());

            int result1 = AnnualGrossSalary(basicSalary);
            int result2 = TakeHomeSalary(result1);

            Console.WriteLine($"Annual Gross Salary: {result1}");
            Console.WriteLine($"Annual Take-Home Salary: {result2}");
        }

        static int AnnualGrossSalary(int basicSalary)
        {
            int salary = 0;
            if(basicSalary<=10000)
            {
                int HRA = 20 * basicSalary/100;
                int DA = 80 * basicSalary/100;
                salary = basicSalary + HRA + DA;
            }
            else if(basicSalary<=20000)
            {
                int HRA = 25 * basicSalary/100;
                int DA = 90 * basicSalary/100;
                salary = basicSalary + HRA + DA; 
            }
            else if(basicSalary>20000)
            {
                int HRA = 30 * basicSalary/100;
                int DA = 95 * basicSalary/100;
                salary = basicSalary + HRA + DA;
            }
            return salary*12;
        }

        static int TakeHomeSalary(int result1)
        {
            int taxes = 6 * result1/100;
            int insurance = 1* result1/100;
            int takeHomeSalary = result1 - taxes - insurance;
            return takeHomeSalary;
        }
    }
}