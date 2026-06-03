using Facade.SubSystems;

namespace Facade;

public class CarFacade
{
    private readonly CarBuilder carBuilder;
    private readonly CarQC carQC;
    private readonly CarDelivery carDelivery;

    public CarFacade()
    {
        carBuilder = new CarBuilder();
        carQC = new CarQC();
        carDelivery = new CarDelivery();
    }

    public void CreateCar()
    {
        Console.WriteLine("---------Create Car---------");
        carBuilder.BuildCar();
        carQC.CarQualityControl();
        carDelivery.DeliverCar();
        Console.WriteLine("-------------END--------------");
    }
}
