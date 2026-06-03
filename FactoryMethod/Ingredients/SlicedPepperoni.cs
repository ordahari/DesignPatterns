using System;
using FactoryMethod.Ingredients.Interface;

namespace FactoryMethod.Ingredients
{
    public class SlicedPepperoni : IPepperoni
    {
        public SlicedPepperoni()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
