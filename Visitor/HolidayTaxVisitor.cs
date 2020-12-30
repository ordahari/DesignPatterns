using System;
using Visitor.Items;

namespace Visitor
{
    public class HolidayTaxVisitor : ITaxVisitor
    {
        public double CalcPriceWithTax(LiquorItem liquorItem)
        {
            return Math.Round((liquorItem.Price * 0.10) + liquorItem.Price);
        }

        public double CalcPriceWithTax(TobaccoItem tobaccoItem)
        {
            return Math.Round((tobaccoItem.Price * 0.28) + tobaccoItem.Price);
        }

        public double CalcPriceWithTax(NecessityItem necessityItem)
        {
            return necessityItem.Price;
        }
    }
}
