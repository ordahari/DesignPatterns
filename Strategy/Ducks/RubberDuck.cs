using Strategy.Stategy.Behaviors;
using Strategy.Stategy.Behaviors.FlyBehaviors;

namespace Strategy.Ducks
{
    public class RubberDuck : BaseDuck
    {
        public RubberDuck() : base(new Squeak(), new FlyNoWay())
        {

        }

        public override string Display()
        {
            return "I’m a Rubber Duck";
        }
    }
}
