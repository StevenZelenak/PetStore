using System;
using System.Collections.Generic;
using System.Text;

namespace ThePetStore.Pets
{
    class Scorpion
    {
        //Inside class things are implicitly private
    public int StingerWidth { get; set; }
    public string Origin { get; set; }
    public string Name { get; set; }
    public bool DoesGlow { get; set; }
    
        //constructor
        public Scorpion(string name)
        {
            Name = name;
        }

        //methods
        public void Attack()
        {
            if (DoesGlow)
            {
                Console.WriteLine($"Scorpion attacks! Get to the hospital");
            }
            else
            {
                Console.WriteLine("Scorpions Kiss, You are fine!");
            }
        }
    }
}
