﻿using FactoryMethod.Ingredients.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
