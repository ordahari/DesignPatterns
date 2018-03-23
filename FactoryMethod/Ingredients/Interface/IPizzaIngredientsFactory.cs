using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Ingredients.Interface
{
    public interface IPizzaIngredientsFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IClams CreateClams();
        IPepperoni CreatePepperoni();
        IVeggies CreateVeggies();
    }
}
