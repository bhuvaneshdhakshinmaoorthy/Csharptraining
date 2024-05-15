using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface1
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }
        public void DisplayName()
        {
            System.Console.Write("Name: DOG ");
        }

        public Dog(string habitat, string eatingHabit)
        {
            // Name = name;
            Habitat = habitat;
            EatingHabit = eatingHabit;
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Habitat: {Habitat} EatingHabit: {EatingHabit}");
        }
    }
}