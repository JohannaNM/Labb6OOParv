using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6OOParv
{
    public abstract class Animal
    {

       public string _name { get; set; }
       private int _age;
       private string _color;
       private string _sex;
       private bool _isDomesticated;

        protected Animal(string name = "no name", int age = 0, string color = "unknown", string sex = "unknown", bool isDomesticated = false)
        {
            _name = name;
            _age = age;
            _color = color;
            _sex = sex;
            _isDomesticated = isDomesticated;
        }

        
        public abstract void makeSound();
        public abstract void eat();
        public abstract void sleep();




    }
}
