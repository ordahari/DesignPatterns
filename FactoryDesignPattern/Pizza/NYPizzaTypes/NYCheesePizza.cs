using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pizza.NYPizzaTypes
{
    public class NYCheesePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Bake NY Cheese Pizza !!");
        }
        public void Box()
        {
            Console.WriteLine("Box NY Cheese Pizza !!");

        }
        public void Cut()
        {
            Console.WriteLine("Cut NY Cheese Pizza !!");
        }
        public void Prepare()
        {
            Console.WriteLine("Prepare NY Cheese Pizza !!");
        }
    }
}
