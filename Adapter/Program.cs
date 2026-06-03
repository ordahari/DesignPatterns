using Adapter.Interface;

namespace Adapter;

internal class Program
{
    private static void Main()
    {
        var turkey = new WildTurkey();
        var duck = new MallardDuck();

        var ducks = new List<IDuck>
        {
            duck,
            new DuckAdapter(turkey)
        };
        Run(ducks);
    }

    private static void Run(List<IDuck> ducks)
    {
        foreach (var duck in ducks)
        {
            duck.Name();
            duck.Fly();
            duck.Quack();
        }
    }
}
