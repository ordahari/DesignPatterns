using FactoryMethod.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PizzaStore
{
    public interface IPizzaStore
    {
        Pizza.Pizza CreatePizza(PizzaType pizzaType);
    }
}
