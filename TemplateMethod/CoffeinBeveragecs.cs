namespace TemplateMethod
{
    // AbstractClass: defines the skeleton of the "prepare a caffeine beverage"
    // algorithm in the template method PrepareRecipe(). Some steps are fixed,
    // some are deferred to subclasses, and one is an optional hook.
    public abstract class CoffeinBeveragecs
    {
        // The template method: defines the algorithm skeleton and is not
        // overridden by subclasses.
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        // Primitive operations: subclasses MUST implement these steps.
        protected abstract void Brew();
        protected abstract void AddCondiments();

        // Fixed steps shared by all beverages.
        private void BoilWater() => Console.WriteLine("Boil the water..");
        private void PourInCup() => Console.WriteLine("Pour into cup..");

        // Hook: a step with a default implementation that subclasses may
        // override to influence the algorithm.
        protected virtual bool CustomerWantsCondiments() => true;
    }
}
