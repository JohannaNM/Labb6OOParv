using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6OOParv
{
    public class Retriver : Dog
    {
        private string _favoriteToy;
        public Retriver(string name = "Unknown", int age = 0, string color = "not defined", string sex = "unknown",
            bool isDomesticated = true, string colorOfCollar = "rainbow", string favoriteToy = "unknown")
            : base(name, age, color, sex, isDomesticated, colorOfCollar)
        {
            _favoriteToy = favoriteToy;
        }

        public override void eat()
        {
            Console.WriteLine($"I am a retriver and my name is: {_name}. I LOVE food, I LOVE to eat, I eat everything!");
        }
        public void GoFetch()
        {
            Console.WriteLine($"{_name} is playing fetch with a {_favoriteToy}");
        }

    }
}
