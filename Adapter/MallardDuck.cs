using Adapter.Interface;

namespace Adapter;

public class MallardDuck : IDuck
{
    public void Fly()
    {
        Console.WriteLine("I'm flying !!");
    }

    public void Name()
    {
        Console.WriteLine("Mallard Duck");
    }

    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}
