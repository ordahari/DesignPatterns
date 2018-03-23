using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pizza.ChicagoPizzaTypes
{
    public class ChicagoClamPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Bake Chicago Clam Pizza !!");
        }
        public void Box()
        {
            Console.WriteLine("Box Chicago Clam Pizza !!");

        }
        public void Cut()
        {
            Console.WriteLine("Cut Chicago Clam Pizza !!");
        }
        public void Prepare()
        {
            Console.WriteLine("Prepare Chicago Clam Pizza !!");
        }
    }
}
