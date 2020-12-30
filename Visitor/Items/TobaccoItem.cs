namespace Visitor.Items
{
    public class TobaccoItem : IVisitable
    {
        public double Price { get; set; }

        public TobaccoItem(double price)
        {
            Price = price;
        }

        public double Accept(ITaxVisitor visitor)
        {
            return visitor.CalcPriceWithTax(this);
        }
    }
}
