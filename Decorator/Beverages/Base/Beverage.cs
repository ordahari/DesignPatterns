using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverages
{
    public abstract class Beverage : IBeverage
    {
        public abstract double Cost { get; }

        public abstract string Description { get; }
    }
}
