using Decorator.Beverages;
using Decorator.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBeverage beverage = new DarkRoast();
            Console.WriteLine("Description:" + beverage.Description);
            Console.WriteLine("Cost:" + beverage.Cost);
            beverage = new MochaDecorator(beverage);
            Console.WriteLine("Description:" + beverage.Description);
            Console.WriteLine("Cost:" + beverage.Cost);
            beverage = new SoyDecorator(beverage);
            Console.WriteLine("Description:" + beverage.Description);
            Console.WriteLine("Cost:"+beverage.Cost);

            IBeverage beverage2 = new Espresso();
            Console.WriteLine("Description:" + beverage2.Description);
            Console.WriteLine("Cost:" + beverage2.Cost);
            beverage2 = new WhipDecorator(beverage2);
            Console.WriteLine("Description:" + beverage2.Description);
            Console.WriteLine("Cost:" + beverage2.Cost);
            beverage2 = new MochaDecorator(beverage2);
            Console.WriteLine("Description:" + beverage2.Description);
            Console.WriteLine("Cost:" + beverage2.Cost);

            Console.Read();

        }
    }
}
