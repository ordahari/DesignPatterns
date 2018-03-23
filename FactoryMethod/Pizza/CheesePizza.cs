using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Ingredients.Interface;

namespace FactoryMethod.Pizza
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(string name, IPizzaIngredientsFactory pizzaIngredientsFactory) : base(name, pizzaIngredientsFactory)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + _name);
            dough = _pizzaIngredientsFactory.CreateDough();
            sauce = _pizzaIngredientsFactory.CreateSauce();
            cheese = _pizzaIngredientsFactory.CreateCheese();
        }
    }
}
