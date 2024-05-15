using System;
using System.Linq;

namespace Linq1;
class Program
{
    public static void Main(string[] args)
    {
        string[] cities = new string[] {"ABU DHABI","AMSTERDAM", "ROME", "MADURAI", "LONDON", "NEW DELHI", "MUMBAI", "NAIROBI"};
        
        System.Console.WriteLine("Enter the character that city starts with");
        char start = char.Parse(Console.ReadLine());
        start.ToString();

        System.Console.WriteLine("Enter the character that city ends with");
        char end = char.Parse(Console.ReadLine());
        end.ToString();
        
        var filteredCities = from city in cities
                            where city.StartsWith(start)
                            where city.EndsWith(end)
                            select city;

        foreach (var city in filteredCities)
        {
            System.Console.WriteLine(city);
        }


    }
}