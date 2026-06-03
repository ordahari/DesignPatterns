using FactoryMethod.Ingredients.ChicagoIngredients;
using FactoryMethod.Pizza;

namespace FactoryMethod.PizzaStore
{
    // ConcreteCreator: overrides the factory method to build Chicago-style pizzas
    // backed by the Chicago ingredient factory.
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza.Pizza CreatePizza(PizzaType pizzaType)
        {
            return pizzaType switch
            {
                PizzaType.CheesePizza => new CheesePizza("Chicago CheesePizza", new ChicagoIngredientsFactory()),
                PizzaType.ClamPizza => new ClamPizza("Chicago ClamPizza", new ChicagoIngredientsFactory()),
                PizzaType.PapperoniPizza => new PepperoniPizza("Chicago Pepperoni", new ChicagoIngredientsFactory()),
                PizzaType.VeggiePizza => new VeggiesPizza("Chicago Veggies", new ChicagoIngredientsFactory()),
                _ => throw new ArgumentOutOfRangeException(nameof(pizzaType), pizzaType, "Unknown pizza type."),
            };
        }
    }
}
