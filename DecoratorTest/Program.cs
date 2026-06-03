using System;
using Decorator.Beverages;
using Decorator.Decorators;


namespace DecoratorTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBeverage beverage = new DarkRoast();
            PrintBeverage(beverage);
            beverage = new MochaDecorator(beverage);
            PrintBeverage(beverage);
            beverage = new SoyDecorator(beverage);
            PrintBeverage(beverage);

            IBeverage beverage2 = new Espresso();
            PrintBeverage(beverage2);
            beverage2 = new WhipDecorator(beverage2);
            PrintBeverage(beverage2);
            beverage2 = new MochaDecorator(beverage2);
            PrintBeverage(beverage2);
        }

        static void PrintBeverage(IBeverage beverage)
        {
            Console.WriteLine("Description:" + beverage.Description);
            Console.WriteLine("Cost:" + beverage.Cost);
        }
    }
}
