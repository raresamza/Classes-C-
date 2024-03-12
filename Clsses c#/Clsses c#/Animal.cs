using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clsses_c_
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Animal(string name, int weight) {
            Name = name;
            Weight = weight;
        }
        public virtual void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void Eat(Food food)
        {
            Console.WriteLine($"Animal eating {food.Name}");
        }
    }
}
