using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6OOParv
{
    public class Terrier : Dog
    {
        private string _dontLike;
        public Terrier(string name = "Unknown", int age = 0, string color = "not defined", string sex = "unknown",
            bool isDomesticated = true, string colorOfCollar = "rainbow", string dontLike = "unknown")
            : base(name, age, color, sex, isDomesticated, colorOfCollar)
        {
            _dontLike = dontLike;
        }

        public override void eat()
        {
            Console.WriteLine($"I am a terrier and my name is {_name}, today I get leftovers for dinner");
        }
        public void dig()
        {
            Console.WriteLine($"{_name} are digging a huge hole in the backyard");
        }
    }
}
