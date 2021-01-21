using System;
using System.Collections.Generic;
using System.Text;

namespace ThePetStore.Pets
{
    class Turtle
    {
        //Properties
        public string Name { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        //Fields
        private bool _isHungry = true;
      

        //constructor(create and return an instance of a class)
        public Turtle(string name, int age)
        {
            Name = name;
            Age = age;
            //Console.WriteLine($"{Name} is {Age} year old.");
        }

        //Method( has a return type)
        public void Eat(string foodType)
        {
            if(_isHungry)
            {
                Console.WriteLine($"The turtle eat the {foodType}");
                _isHungry = false;
            }
            else
            {
                Console.WriteLine("Shakes its head and says nty");
            }
            
        }

        public void ShowTime(string occasion)
        {
            if (occasion != null)
            {
                Console.WriteLine($"It is a {occasion}!");
            }
            else
            {
                Console.WriteLine($"no occasion...");
            }

            DressUp("Tie");

        }

        //method overloading
        public void Eat()
        {
            Eat("Pellets");
        }

        private void DressUp(string clothing)
        {
            Console.WriteLine($"The tutrtle is wearing a {clothing}");
        }
    }
}
