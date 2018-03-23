using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory;

namespace AbstractFactory.PizzaStore
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public ChicagoPizzaStore() : base(new ChicagoPizzaFactory())
        {
        }
    }
}
