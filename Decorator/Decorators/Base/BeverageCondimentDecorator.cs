using Decorator.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class BeverageCondimentDecorator : IBeverage
    {
        protected IBeverage _beverage;
        public BeverageCondimentDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public virtual double Cost
        {
            get
            {
                return _beverage.Cost;
            }
        }

        public virtual string Description
        {

            get
            {
                return _beverage.Description;
            }
        }


    }
}
