using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Pizza;
using AbstractFactory.Pizza.NYPizzaTypes;

namespace AbstractFactory.Factory
{
    public class NYPizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza(PizzaType pizzaType)
        {

            switch (pizzaType)
            {
                case PizzaType.CheesePizza:
                    return new NYCheesePizza();
                case PizzaType.ClamPizza:
                    return new NYClamPizza();
                case PizzaType.PapperoniPizza:
                    return new NYPapperoniPizza();
                case PizzaType.VeggiePizza:
                    return new NYVeggiePizza();
                default:
                    return null;
            }

        }
    }
}
