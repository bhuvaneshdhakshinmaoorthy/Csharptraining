using System;
namespace Interface1;
class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog("human homes and yards","at least two meals each day, about 12 hours apart"); 
        dog.DisplayName();
        dog.DisplayInfo();

        Duck duck = new Duck("anywhere that is near open water","aquatic vegetation");
        duck.DisplayName();
        duck.DisplayInfo();
    }
}