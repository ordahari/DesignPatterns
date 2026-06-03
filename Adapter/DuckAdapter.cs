using Adapter.Interface;

namespace Adapter;

public class DuckAdapter : IDuck
{
    private readonly ITurkey _turkey;

    public DuckAdapter(ITurkey turkey)
    {
        _turkey = turkey;
    }

    public void Fly()
    {
        // A turkey flies only short distances, so flap several times
        // to cover the distance a duck would in one flight.
        for (int i = 0; i < 5; i++)
        {
            _turkey.Fly();
        }
    }

    public void Name()
    {
        Console.WriteLine(_turkey.GetType().Name);
    }

    public void Quack()
    {
        _turkey.Gobble();
    }
}
