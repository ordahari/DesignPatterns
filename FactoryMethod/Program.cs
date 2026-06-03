using FactoryMethod.Pizza;
using FactoryMethod.PizzaStore;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore.PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
            Order(chicagoPizzaStore, PizzaType.CheesePizza);
            Order(chicagoPizzaStore, PizzaType.ClamPizza);
            Order(chicagoPizzaStore, PizzaType.PapperoniPizza);
            Order(chicagoPizzaStore, PizzaType.VeggiePizza);

            PizzaStore.PizzaStore nYPizzaStore = new NYPizzaStore();
            Order(nYPizzaStore, PizzaType.CheesePizza);
            Order(nYPizzaStore, PizzaType.ClamPizza);
            Order(nYPizzaStore, PizzaType.PapperoniPizza);
            Order(nYPizzaStore, PizzaType.VeggiePizza);
        }

        // Drives the Factory Method: OrderPizza runs the shared steps while the
        // store's overridden CreatePizza decides the concrete product.
        public static void Order(PizzaStore.PizzaStore store, PizzaType pizzaType)
        {
            store.OrderPizza(pizzaType);
            Console.WriteLine("--------------Reedy----------------");
        }
    }
}
