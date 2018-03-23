using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Ingredients.ChicagoIngredients;
using FactoryMethod.Pizza;

namespace FactoryMethod.PizzaStore
{
   public class ChicagoPizzaStore : IPizzaStore
    {
        public Pizza.Pizza CreatePizza(PizzaType pizzaType) {

            switch (pizzaType)
            {
                case PizzaType.CheesePizza:
                    return new CheesePizza("Chicago CheesePizza", new ChicagoIngredientsFactory());

                case PizzaType.ClamPizza:
                    return new ClamPizza("Chicago ClamPizza", new ChicagoIngredientsFactory());

                case PizzaType.PapperoniPizza:
                    return new PepperoniPizza("Chicago Pepperoni", new ChicagoIngredientsFactory());

                case PizzaType.VeggiePizza:
                    return new VeggiesPizza("Chicago Veggies", new ChicagoIngredientsFactory());

                default:
                    return null;
                    break;
            }
        }

    }
}
