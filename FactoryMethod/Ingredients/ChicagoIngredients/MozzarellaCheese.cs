using FactoryMethod.Ingredients.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Ingredients.ChicagoIngredients
{
    public class MozzarellaCheese : ICheese
    {
        public MozzarellaCheese()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
