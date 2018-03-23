using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pizza.NYPizzaTypes
{
    public class NYPapperoniPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Bake NY Papperoni Pizza !!");
        }
        public void Box()
        {
            Console.WriteLine("Box NY Papperoni Pizza !!");

        }
        public void Cut()
        {
            Console.WriteLine("Cut NY Papperoni Pizza !!");
        }
        public void Prepare()
        {
            Console.WriteLine("Prepare NY Papperoni Pizza !!");
        }
    }
}
