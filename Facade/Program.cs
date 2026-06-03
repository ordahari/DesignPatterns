namespace Facade;

internal class Program
{
    private static void Main()
    {
        var carFacade = new CarFacade();
        carFacade.CreateCar();
    }
}
