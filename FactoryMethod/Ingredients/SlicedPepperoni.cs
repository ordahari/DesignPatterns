using FactoryMethod.Ingredients.Interface;
using System;

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
