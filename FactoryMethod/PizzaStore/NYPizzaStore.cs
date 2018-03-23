using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Ingredients.NYIngredients;
using FactoryMethod.Pizza;

namespace FactoryMethod.PizzaStore
{
    public class NYPizzaStore : IPizzaStore
    {

        public Pizza.Pizza CreatePizza(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.CheesePizza:
                    return new CheesePizza("NY CheesePizza", new NYIngredientsFactory());

                case PizzaType.ClamPizza:
                    return new ClamPizza("NY ClamPizza", new NYIngredientsFactory());

                case PizzaType.PapperoniPizza:
                    return new PepperoniPizza("NY Pepperoni", new NYIngredientsFactory());

                case PizzaType.VeggiePizza:
                    return new VeggiesPizza("NY Veggies", new NYIngredientsFactory());

                default:
                    return null;
                    break;
            }

        }


    }
}
