using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class CoffeinBeveragecs
    {

        public void PrepareRecipt()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void AddCondiments();
        private void PourInCup() {

        }
        protected abstract void Brew();
        private void BoilWater() {
            Console.WriteLine("Boil the water..");
        }
    }
}
