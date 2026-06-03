namespace Decorator.Beverages
{
    public class Espresso : Beverage
    {

        const double COST = 1.99;

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
                return "Espresso";
            }
        }

    }
}
