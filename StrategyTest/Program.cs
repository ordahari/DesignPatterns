using Strategy.Ducks;
using Strategy.Stategy.Behaviors;
using Strategy.Stategy.Behaviors.FlyBehaviors;

namespace StrategyTest
{
    class Program
    {
        static void Main()
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
                Console.WriteLine(duck.Swim());
                Console.WriteLine(duck.PerformFly());
                Console.WriteLine(duck.PerformQuack());
                Console.WriteLine();
            }

            // Strategy in action: swap a duck's behaviors at runtime.
            var decoy = duckList[3];
            Console.WriteLine("Giving the decoy duck a rocket and a voice at runtime...");
            decoy.SetFlyBehavior(new FlyWithWings());
            decoy.SetQuackBehavior(new RegularQuacking());
            Console.WriteLine(decoy.Display());
            Console.WriteLine(decoy.PerformFly());
            Console.WriteLine(decoy.PerformQuack());
        }
    }
}
