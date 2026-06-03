namespace Decorator.Beverages
{
    public class DarkRoast : Beverage
    {

        const double COST = 0.99;

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
                return "Dark Roast";
            }
        }



    }
}
