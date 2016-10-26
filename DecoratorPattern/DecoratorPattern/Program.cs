using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage coffee = new Espresso();

            Console.WriteLine($"{coffee.Description}: £{coffee.Cost}");

            coffee = new DarkRoast();
            coffee = new Mocha(coffee);
            coffee = new Mocha(coffee);
            coffee = new Whip(coffee);

            Console.WriteLine($"{coffee.Description}: £{coffee.Cost}");

            //or, decorating decorators ...

            coffee = new Vanilla(new Mocha(new Mocha(new DarkRoast())));
            Console.WriteLine($"{coffee.Description}: £{coffee.Cost}");

            Console.ReadKey();
        }
    }
}
