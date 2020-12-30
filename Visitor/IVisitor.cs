using Visitor.Items;

namespace Visitor
{
    public interface ITaxVisitor
    {
        double CalcPriceWithTax(LiquorItem liquorItem);
        double CalcPriceWithTax(TobaccoItem tobaccoItem);
        double CalcPriceWithTax(NecessityItem necessityItem);
    }
}
