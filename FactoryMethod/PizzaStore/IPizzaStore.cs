using FactoryMethod.Pizza;

namespace FactoryMethod.PizzaStore
{
    // Creator: defines the template OrderPizza operation that relies on the
    // CreatePizza factory method. Concrete stores override CreatePizza to decide
    // which concrete Pizza (product) gets built, so the creator never depends on
    // the concrete product types.
    public abstract class PizzaStore
    {
        // The factory method. Subclasses (ConcreteCreators) pick the concrete product.
        public abstract Pizza.Pizza CreatePizza(PizzaType pizzaType);

        // Template operation: same ordering steps for every store, while the
        // actual pizza created is deferred to the subclass via CreatePizza.
        public Pizza.Pizza OrderPizza(PizzaType pizzaType)
        {
            var pizza = CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
