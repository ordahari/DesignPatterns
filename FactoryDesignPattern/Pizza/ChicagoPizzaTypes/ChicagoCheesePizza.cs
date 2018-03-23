using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pizza.ChicagoPizzaTypes
{
    public class ChicagoCheesePizza : IPizza
    {

        public void Bake()
        {
            Console.WriteLine("Bake Chicago Cheese Pizza !!");
        }
        public void Box()
        {
            Console.WriteLine("Box Chicago Cheese Pizza !!");

        }
        public void Cut()
        {
            Console.WriteLine("Cut Chicago Cheese Pizza !!");
        }
        public void Prepare()
        {
            Console.WriteLine("Prepare Chicago Cheese Pizza !!");
        }
    }
}
