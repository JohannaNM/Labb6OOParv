using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6OOParv
{
    public class Dog : Animal
    {
        private string _colorOfCollar;
        public Dog(string name = "Unknown", int age = 0, string color = "not defined", string sex = "Unknown", bool isDomesticated = true, string colorOfCollar = "rainbow")
            : base(name, age, color, sex, isDomesticated)
        {
            _name = name;
            _colorOfCollar = colorOfCollar;
        }

        public override void eat()
        {
            Console.WriteLine("Dogs eat dogfood");
        }

        public override void makeSound()
        {
            Console.WriteLine($"{_name} the dog says: VOFF VOFF! ");
        }

        public override void sleep()
        {
            Console.WriteLine("Sleeps on the bed");
        }

        public void WalkOnLeash()
        {
            Console.WriteLine("Taking a walk with my human");
        }
    }
}
