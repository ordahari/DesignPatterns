using Microsoft.VisualStudio.TestTools.UnitTesting;
using Visitor;
using Visitor.Items;

namespace VisitorTests
{
    [TestClass]
    public class TaxVisitorTests
    {


        [TestMethod]
        public void CalculatePriceWithTaxForNecessityItem()
        {
            ITaxVisitor taxCalculator = new TaxVisitor();

            var eggs = new NecessityItem(12);

            Assert.AreEqual(12, eggs.Accept(taxCalculator));
        }
        [TestMethod]
        public void CalculatePriceWithTaxForLiquorItem()
        {
            ITaxVisitor taxCalculator = new TaxVisitor();

            var vodca = new LiquorItem(70);

            Assert.AreEqual(94, vodca.Accept(taxCalculator));
        }
        [TestMethod]
        public void CalculatePriceWithTaxForTobaccoItem()
        {
            ITaxVisitor taxCalculator = new TaxVisitor();

            var LM = new TobaccoItem(30);

            Assert.AreEqual(52, LM.Accept(taxCalculator));
        }
    }
}
