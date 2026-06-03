namespace Decorator.Beverages
{
    public class Decaf : Beverage
    {
        const double COST = 1.05;

        public override double Cost
        {
            get
            {
                return COST;
            }
        }

        public override string Description
        {
            get
            {
                return "Decaf";
            }
        }
    }
}
