using Strategy.Stategy.Behaviors;

namespace Strategy.Ducks
{
    public abstract class BaseDuck
    {
        private IQuackBehavior _quackBehavior;
        private IFlyBehavior _flyBehavior;

        public BaseDuck(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
        {
            _quackBehavior = quackBehavior;
            _flyBehavior = flyBehavior;
        }


        public string PerformFly()
        {
            return _flyBehavior.Fly();
        }

        public string PerformQuack()
        {
            return _quackBehavior.Quack();
        }

        // Swap the algorithm at runtime — the heart of the Strategy pattern.
        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public string Swim()
        {
            return "All ducks float, even decoys!";
        }

        public abstract string Display();

    }
}
