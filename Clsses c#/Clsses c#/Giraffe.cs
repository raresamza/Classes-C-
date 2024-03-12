using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clsses_c_
{
    internal class Giraffe:Herbivore
    {
        public Giraffe(string name, int weight) : base(name, weight)
        {
        }

        public override void Eat(Food food)
        {
            Console.WriteLine($"GIrrafe eating {food.Name}");
        }
    }
}
