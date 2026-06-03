using FactoryMethod.Ingredients.Interface;

namespace FactoryMethod.Pizza
{
    // Product base class: the abstract Pizza all concrete products derive from.
    public abstract class Pizza
    {
        protected string _name;

        protected IPizzaIngredientsFactory _pizzaIngredientsFactory;

        // Ingredients are populated during Prepare() by the ingredient factory,
        // and each concrete pizza only uses the subset it needs, so they are nullable.
        protected IDough? dough;
        protected ISauce? sauce;
        protected ICheese? cheese;
        protected IClams? clams;
        protected IPepperoni? pepperoni;
        protected IVeggies? veggies;


        public Pizza(string name, IPizzaIngredientsFactory pizzaIngredientsFactory)
        {
            _name = name;
            _pizzaIngredientsFactory = pizzaIngredientsFactory;
        }

        public abstract void Prepare();


        public void Bake()
        {
            Console.WriteLine("Bake For 25 Minuets at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Please Pizza in official PizzaStore box");
        }


    }
}
