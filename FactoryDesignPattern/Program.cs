using AbstractFactory.Pizza;
using AbstractFactory.PizzaStore;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)

        {
            var chicagopizzaStore = new ChicagoPizzaStore();
            Console.WriteLine("Chicago Pizza Store");
            chicagopizzaStore.OrderPizza(PizzaType.CheesePizza);
            chicagopizzaStore.OrderPizza(PizzaType.ClamPizza);
            chicagopizzaStore.OrderPizza(PizzaType.PapperoniPizza);
            chicagopizzaStore.OrderPizza(PizzaType.VeggiePizza);

            Console.WriteLine("NY Pizza Store");
            var nY_PizzaStore = new NYPizzaStore();
            nY_PizzaStore.OrderPizza(PizzaType.CheesePizza);
            nY_PizzaStore.OrderPizza(PizzaType.ClamPizza);
            nY_PizzaStore.OrderPizza(PizzaType.PapperoniPizza);
            nY_PizzaStore.OrderPizza(PizzaType.VeggiePizza);

            Console.Read();
        }
    }
}
