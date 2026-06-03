using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Ingredients.Interface;

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
