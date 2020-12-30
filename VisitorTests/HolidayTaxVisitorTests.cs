using Microsoft.VisualStudio.TestTools.UnitTesting;
using Visitor;
using Visitor.Items;

namespace VisitorTests
{
    [TestClass]
    public class HolidayTaxVisitorTests
    {


        [TestMethod]
        public void CalculatePriceWithTaxForNecessityItem()
        {
            ITaxVisitor taxCalculator = new HolidayTaxVisitor();

            var eggs = new NecessityItem(12);

            Assert.AreEqual(12, eggs.Accept(taxCalculator));
        }
        [TestMethod]
        public void CalculatePriceWithTaxForLiquorItem()
        {
            ITaxVisitor taxCalculator = new HolidayTaxVisitor();

            var vodca = new LiquorItem(70);

            Assert.AreEqual(77, vodca.Accept(taxCalculator));
        }
        [TestMethod]
        public void CalculatePriceWithTaxForTobaccoItem()
        {
            ITaxVisitor taxCalculator = new HolidayTaxVisitor();

            var LM = new TobaccoItem(30);

            Assert.AreEqual(38, LM.Accept(taxCalculator));
        }
    }
}
