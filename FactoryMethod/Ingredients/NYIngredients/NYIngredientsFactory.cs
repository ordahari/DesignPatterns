using FactoryMethod.Ingredients.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Ingredients.NYIngredients
{
    public class NYIngredientsFactory : IPizzaIngredientsFactory
    {
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }
        public IClams CreateClams()
        {
            return new FreshClams();
        }
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }
        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }
        public IVeggies CreateVeggies()
        {
            return new Veggies();
        }
    }
}
