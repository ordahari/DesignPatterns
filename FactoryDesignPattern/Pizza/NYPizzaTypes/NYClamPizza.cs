using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pizza.NYPizzaTypes
{
    public class NYClamPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Bake NY Clam Pizza !!");
        }
        public void Box()
        {
            Console.WriteLine("Box NY Clam Pizza !!");

        }
        public void Cut()
        {
            Console.WriteLine("Cut NY Clam Pizza !!");
        }
        public void Prepare()
        {
            Console.WriteLine("Prepare NY Clam Pizza !!");
        }
    }
}
