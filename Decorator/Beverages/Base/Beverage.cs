namespace Decorator.Beverages
{
    public abstract class Beverage : IBeverage
    {
        public abstract double Cost { get; }

        public abstract string Description { get; }
    }
}
