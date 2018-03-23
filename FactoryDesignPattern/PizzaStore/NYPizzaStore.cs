using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory;

namespace AbstractFactory.PizzaStore
{
   public class NYPizzaStore : PizzaStore
    {
        public NYPizzaStore() : base(new NYPizzaFactory())
        {
        }
    }
}
