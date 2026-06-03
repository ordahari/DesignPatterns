using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Ingredients.Interface;

namespace FactoryMethod.Ingredients.NYIngredients
{
    public class ReggianoCheese : ICheese
    {
        public ReggianoCheese()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
