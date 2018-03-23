using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Pizza;
using AbstractFactory.Pizza.ChicagoPizzaTypes;

namespace AbstractFactory.Factory
{
    public class ChicagoPizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza(PizzaType pizzaType)
        {

            switch (pizzaType)
            {
                case PizzaType.CheesePizza:
                    return new ChicagoCheesePizza();
                case PizzaType.ClamPizza:
                    return new ChicagoClamPizza();
                case PizzaType.PapperoniPizza:
                    return new ChicagoPapperoniPizza();
                case PizzaType.VeggiePizza:
                    return new ChicagoVeggiePizza();
                default:
                    return null;
            }

        }
    }
}
