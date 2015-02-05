using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Dog : Animal
    {
        public Dog(string name, int age, Gender gender)
            : base(name, age, gender) { }

        public new void ProduceSound()
        {
            Console.WriteLine("Wof!");
        }
    }
}
