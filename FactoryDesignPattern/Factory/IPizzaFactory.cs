using AbstractFactory.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public interface IPizzaFactory
    {
        IPizza CreatePizza(PizzaType pizzaType);
    }
}
