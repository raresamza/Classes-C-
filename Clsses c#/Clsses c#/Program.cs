using Clsses_c_;
using System.Globalization;

Animal animal = new Animal("bat",1);
Herbivore herbivore = new Herbivore("antelope", 250);
Giraffe giraffe = new Giraffe("giraffe", 1000);
Console.WriteLine("Optinal parameter method example:");
giraffe.OptionalParaemeterMethod(10);
giraffe.OptionalParaemeterMethod(10,"optinal parameter is given");
Animal[] animals = {animal, herbivore, giraffe};
Console.WriteLine();
Console.WriteLine("\"is\" operator example");
foreach (Animal ani in animals)
{
    if (ani is Giraffe)
    {
        Console.WriteLine($"{ani.Name} is an instance of the Giraffe class");
    }
    else {
        Console.WriteLine($"{ani.Name} is not an instance of the Giraffe class");

    }
}
Console.WriteLine();
Console.WriteLine("Overring example:");
foreach (Animal ani in animals)
{
    ani.Eat();
}
Console.WriteLine();
Console.WriteLine("Overloading example:");
giraffe.Eat();
giraffe.Eat(new Food { Name = "Leaf" });
Console.WriteLine();
object testAnimal = new Herbivore("test", 0);
Console.WriteLine("\"as\" operator example:");
(testAnimal as Herbivore).Eat();