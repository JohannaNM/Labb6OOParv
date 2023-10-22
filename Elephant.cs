using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6OOParv
{
    public class Elephant : Animal
    {
        private int _weight;
        public Elephant(string name = "Unknown", int age = 0, string color = "gray", string sex = "Unknown", bool isDomesticated = false, int weight = 0)
            : base(name, age, color, sex, isDomesticated)
        {
            _name = name;
            _weight = weight;
        }

        public override void eat()
        {
            Console.WriteLine("Elephants eats the leaves of trees and bushes");
        }

        public override void makeSound()
        {
            Console.WriteLine($"{_name} the elephant says: TUUUUT TUUUT");
        }

        public override void sleep()
        {
            Console.WriteLine("Elephants sleep on the ground");
        }

        public void cool()
        {
            Console.WriteLine("Taking a cooling mudbath");
        }
    }
}
