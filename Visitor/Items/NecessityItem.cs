namespace Visitor.Items
{
    public class NecessityItem : IVisitable
    {
        public NecessityItem(double price)
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
