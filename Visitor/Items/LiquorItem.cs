namespace Visitor.Items
{
    public class LiquorItem : IVisitable
    {
        public LiquorItem(double price)
        {
            Price = price;
        }

        public double Price { get; set; }

        public double Accept(ITaxVisitor visitor)
        {
            return visitor.CalcPriceWithTax(this);
        }
    }
}
