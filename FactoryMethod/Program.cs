using FactoryMethod.PizzaStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicagoPizzaStore = new ChicagoPizzaStore();
            Run(chicagoPizzaStore.CreatePizza(Pizza.PizzaType.CheesePizza));
            Run(chicagoPizzaStore.CreatePizza(Pizza.PizzaType.ClamPizza));
            Run(chicagoPizzaStore.CreatePizza(Pizza.PizzaType.PapperoniPizza));
            Run(chicagoPizzaStore.CreatePizza(Pizza.PizzaType.VeggiePizza));

            var nYPizzaStore = new NYPizzaStore();
            Run(nYPizzaStore.CreatePizza(Pizza.PizzaType.CheesePizza));
            Run(nYPizzaStore.CreatePizza(Pizza.PizzaType.ClamPizza));
            Run(nYPizzaStore.CreatePizza(Pizza.PizzaType.PapperoniPizza));
            Run(nYPizzaStore.CreatePizza(Pizza.PizzaType.VeggiePizza));

            Console.Read();
        }

        public static void Run(Pizza.Pizza pizza)
        {
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            Console.WriteLine("--------------Reedy----------------");
        }
    }
}
