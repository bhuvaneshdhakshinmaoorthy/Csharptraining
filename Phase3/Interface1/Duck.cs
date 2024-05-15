using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface1
{
    public class Duck : IAnimal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }
        public void DisplayName()
        {
            System.Console.Write("Name: Duck ");
        }

        public Duck(string habitat, string eatingHabit)
        {
            Habitat = habitat;
            EatingHabit = eatingHabit;
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Habitat: {Habitat} EatingHabit: {EatingHabit}");
        }
    }
}