using FactoryMethod.Ingredients.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Ingredients
{
    public class Veggies : IVeggies
    {
        public Veggies()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
