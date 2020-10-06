using System;
using System.Collections.Generic;
using System.Text;


namespace cSharp_fundamentals
{
    class Program
    {

        static void Main(string[] arg)
        {
            Animal a = new Animal(5.0, 300.2, "Roar", "Tiger");
            a.Name = "Lion";
            Console.WriteLine(a.toString());
            Console.WriteLine(Animal.getNumOfAnimals());

            //Specifying the order of the param
            Console.WriteLine(a.getSum(num2: 3, num1: 4));


            //Different way to create object
            Animal Grover = new Animal
            {
                height = 5,
                weight = 20,
                name = "Grover",
                sound = "Grr"
            };
            Console.WriteLine(Grover.toString());

            Dog d = new Dog(2, 15, "Woff", "Misti", "Meat");
            Console.WriteLine(d.toString());

        }
    }
}
