using System;
using Visitor.Items;

namespace Visitor
{
    public class TaxVisitor : ITaxVisitor
    {
        public double CalcPriceWithTax(LiquorItem liquorItem)
        {
            return Math.Round((liquorItem.Price * 0.35) + liquorItem.Price);
        }

        public double CalcPriceWithTax(TobaccoItem tobaccoItem)
        {
            return Math.Round((tobaccoItem.Price * 0.72) + tobaccoItem.Price);
        }

        public double CalcPriceWithTax(NecessityItem necessityItem)
        {
           return necessityItem.Price;
        }

    }
}
