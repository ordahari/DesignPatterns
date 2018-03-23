using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pizza.NYPizzaTypes
{
    public class NYVeggiePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Bake NY Veggie Pizza !!");
        }
        public void Box()
        {
            Console.WriteLine("Box NY Veggie Pizza !!");

        }
        public void Cut()
        {
            Console.WriteLine("Cut NY Veggie Pizza !!");
        }
        public void Prepare()
        {
            Console.WriteLine("Prepare NY Veggie Pizza !!");
        }
    }
}
