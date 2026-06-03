namespace Decorator.Beverages
{
    public class HouseBlend : Beverage
    {

        const double COST = 0.89;

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
                return "House Blend Coffee";
            }
        }

    }
}
