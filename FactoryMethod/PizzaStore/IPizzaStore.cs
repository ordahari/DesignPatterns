using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Pizza;

namespace FactoryMethod.PizzaStore
{
    public interface IPizzaStore
    {
        Pizza.Pizza CreatePizza(PizzaType pizzaType);
    }
}
