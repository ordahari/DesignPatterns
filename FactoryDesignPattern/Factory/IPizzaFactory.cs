using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Pizza;

namespace AbstractFactory.Factory
{
    public interface IPizzaFactory
    {
        IPizza CreatePizza(PizzaType pizzaType);
    }
}
