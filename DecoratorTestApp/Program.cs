using Decorator;
using Decorator.Condiments;
using System;

namespace DecoratorTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            beverage = new Whip(beverage);
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost());

            Beverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine(beverage1.GetDescription() + " $" + beverage1.cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.cost());

            Console.WriteLine("Hello World!");
        }
    }
}
