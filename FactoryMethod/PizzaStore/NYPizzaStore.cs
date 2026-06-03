using FactoryMethod.Ingredients.NYIngredients;
using FactoryMethod.Pizza;

namespace FactoryMethod.PizzaStore
{
    // ConcreteCreator: overrides the factory method to build NY-style pizzas
    // backed by the NY ingredient factory.
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza.Pizza CreatePizza(PizzaType pizzaType)
        {
            return pizzaType switch
            {
                PizzaType.CheesePizza => new CheesePizza("NY CheesePizza", new NYIngredientsFactory()),
                PizzaType.ClamPizza => new ClamPizza("NY ClamPizza", new NYIngredientsFactory()),
                PizzaType.PapperoniPizza => new PepperoniPizza("NY Pepperoni", new NYIngredientsFactory()),
                PizzaType.VeggiePizza => new VeggiesPizza("NY Veggies", new NYIngredientsFactory()),
                _ => throw new ArgumentOutOfRangeException(nameof(pizzaType), pizzaType, "Unknown pizza type."),
            };
        }
    }
}
