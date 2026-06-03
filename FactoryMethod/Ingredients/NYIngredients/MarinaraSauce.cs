using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Ingredients.Interface;

namespace FactoryMethod.Ingredients.NYIngredients
{
    public class MarinaraSauce : ISauce
    {
        public MarinaraSauce()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
