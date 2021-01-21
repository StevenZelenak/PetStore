using System;
using ThePetStore.Pets;

namespace ThePetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle Mertle = new Turtle("Mertle", 72);
            //Mertle.Name = "Mertle";
            //Mertle.Age = 72;
            Mertle.Eat("Lettuce");
            Mertle.Eat("food");
            //Console.WriteLine($"{Mertle.Name} is {Mertle.Age} year old.");
            Scorpion scorpion1 = new Scorpion("Steven");
            scorpion1.Attack();
        }
    }
}
