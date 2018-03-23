using FactoryMethod.Ingredients.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Ingredients.ChicagoIngredients
{
    public class ChicagoIngredientsFactory : IPizzaIngredientsFactory
    {
        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }
        public IClams CreateClams()
        {
            return new FrozenClams();
        }
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }
        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }
        public IVeggies CreateVeggies()
        {
            return new Veggies();
        }
    }
}
