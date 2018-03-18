using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverages;

namespace Decorator.Decorators
{
    public class MochaDecorator : BeverageCondimentDecorator
    {


        public MochaDecorator(IBeverage beverage) : base(beverage)
        {

        }


        public override double Cost
        {
            get
            {
                return _beverage.Cost + 0.20;
            }
        }

        public override string Description
        {
            get
            {
                return $"{_beverage.Description} , Mocha";
            }
        }
    }
}
