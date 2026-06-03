using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Ingredients.Interface;

namespace FactoryMethod.Ingredients.ChicagoIngredients
{
    public class PlumTomatoSauce : ISauce
    {
        public PlumTomatoSauce()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
