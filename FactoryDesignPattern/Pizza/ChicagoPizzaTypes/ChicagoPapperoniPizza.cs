using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pizza.ChicagoPizzaTypes
{
    public class ChicagoPapperoniPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Bake Chicago Papperoni Pizza !!");
        }
        public void Box()
        {
            Console.WriteLine("Box Chicago Papperoni Pizza !!");

        }
        public void Cut()
        {
            Console.WriteLine("Cut Chicago Papperoni Pizza !!");
        }
        public void Prepare()
        {
            Console.WriteLine("Prepare Chicago Papperoni Pizza !!");
        }
    }
}
