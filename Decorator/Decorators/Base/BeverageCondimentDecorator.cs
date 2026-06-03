using Decorator.Beverages;

namespace Decorator.Decorators
{
    public abstract class BeverageCondimentDecorator : IBeverage
    {
        protected readonly IBeverage _beverage;
        protected BeverageCondimentDecorator(IBeverage beverage)
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
