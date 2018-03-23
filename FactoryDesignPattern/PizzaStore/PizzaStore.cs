using AbstractFactory.Factory;
using AbstractFactory.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PizzaStore
{
    public abstract class PizzaStore
    {
        private IPizzaFactory _pizzaFactory;
        public PizzaStore(IPizzaFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }


        public IPizza OrderPizza(PizzaType pizzaType)
        {
            IPizza pizza = _pizzaFactory.CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
