using Adapter.Interface;

namespace Adapter;

public class WildTurkey : ITurkey
{
    public void Fly()
    {
        Console.WriteLine("I'm flying a Short distance");
    }

    public void Gobble()
    {
        Console.WriteLine("Gobble gobble..");
    }
}
