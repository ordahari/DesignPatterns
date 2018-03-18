using Strategy.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var duckList = new List<BaseDuck>
            {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck(),
                new DecoyDuck()
            };

            foreach (var duck in duckList)
            {
                Console.WriteLine(duck.Display());
                Console.WriteLine(duck.swim());
                Console.WriteLine(duck.PerformFly());
                Console.WriteLine(duck.PerformQuack());
            }

            Console.Read();
        }
    }
}
