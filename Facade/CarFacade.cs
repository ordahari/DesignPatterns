using Facade.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CarFacade
    {
        CarBuilder carBilder;
        CarQC carQC;
        CarDelivery carDelivery;
        public CarFacade()
        {
            this.carBilder = new CarBuilder();
            this.carQC = new CarQC();
            this.carDelivery = new CarDelivery();
        }

        public void CreateCar()
        {
            Console.WriteLine("---------Create Car---------");
            carBilder.BuildCar();
            carQC.CarQualityControl();
            carDelivery.DeliverCar();
            Console.WriteLine("-------------END--------------");
        }

    }
}
