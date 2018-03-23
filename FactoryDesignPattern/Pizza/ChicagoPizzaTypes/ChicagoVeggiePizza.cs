using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pizza.ChicagoPizzaTypes
{
    public class ChicagoVeggiePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Bake Chicago Veggie Pizza !!");
        }
        public void Box()
        {
            Console.WriteLine("Box Chicago Veggie Pizza !!");

        }
        public void Cut()
        {
            Console.WriteLine("Cut Chicago Veggie Pizza !!");
        }
        public void Prepare()
        {
            Console.WriteLine("Prepare Chicago Veggie Pizza !!");
        }
    }
}
