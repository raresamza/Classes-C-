using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clsses_c_
{
    internal class Herbivore:Animal
    {
        public Herbivore(string name, int weight) : base(name, weight)
        {
        }

        public void OptionalParaemeterMethod(int required, string optional = "this parameter is optional")
        {
            Console.WriteLine($"The required parameter is: {required} \nIf the text \"this parameter is optipnal\" is displayed after \":\" that means the optional paramater is not given in the method call: {optional}");
        }

        public override void Eat()
        {
            Console.WriteLine($"Herbivores eat plants...");
        }
    }
}
