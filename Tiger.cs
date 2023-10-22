using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6OOParv
{
    public class Tiger : Animal
    {
        private string _isNativeTo;
        public Tiger(string name = "Unknown", int age = 0, string color = "orange/black", string sex = "Unknown", bool isDomesticated = false, string isNativeTo = "Unknown")
            : base(name, age, color, sex, isDomesticated)
        {
            _name = name;
            _isNativeTo = isNativeTo;
        }

        public void Hunt()
        {
            Console.WriteLine($"{_name} Hunts the zookeepers");
        }
        public override void eat()
        {
            Console.WriteLine("Tigers eat raw meat");
        }

        public override void makeSound()
        {
            Console.WriteLine($"{_name} the tiger says: GRRR GRRR");
        }

        public override void sleep()
        {
            Console.WriteLine("Sleeps in the shade of a tree");
        }
    }


}
