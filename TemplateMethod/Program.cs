namespace TemplateMethod
{
    // ConcreteClass: supplies the deferred steps for coffee.
    public sealed class Coffee : CoffeinBeveragecs
    {
        protected override void Brew() => Console.WriteLine("Dripping coffee through filter..");
        protected override void AddCondiments() => Console.WriteLine("Add sugar and milk..");
    }

    // ConcreteClass: supplies the deferred steps for tea and overrides the
    // hook to decline condiments.
    public sealed class Tea : CoffeinBeveragecs
    {
        protected override void Brew() => Console.WriteLine("Steep the tea..");
        protected override void AddCondiments() => Console.WriteLine("Add lemon..");
        protected override bool CustomerWantsCondiments() => false;
    }

    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Making coffee:");
            CoffeinBeveragecs coffee = new Coffee();
            coffee.PrepareRecipe();

            Console.WriteLine();

            Console.WriteLine("Making tea (no condiments):");
            CoffeinBeveragecs tea = new Tea();
            tea.PrepareRecipe();
        }
    }
}
