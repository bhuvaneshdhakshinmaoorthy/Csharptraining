using System;
using System.Linq;

namespace Linq2;
class Program
{
    public static void Main(string[] args)
    {
        string[] cities = new string[] {"ABU DHABI", "AMSTERDAM", "ROME", "PARIS", "CALIFORNIA", "LONDON", "NEW DELHI", "ZURICH", "NAIROBI"};
        var orderedCities = cities.OrderBy(city => city.Length);
        
        foreach (var city in orderedCities)
        {
            System.Console.WriteLine(city);
        }
    }
}