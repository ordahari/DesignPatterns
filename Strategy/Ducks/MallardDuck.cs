using Strategy.Stategy.Behaviors;
using Strategy.Stategy.Behaviors.FlyBehaviors;

namespace Strategy.Ducks
{
    public class MallardDuck : BaseDuck
    {
        public MallardDuck() : base(new RegularQuacking(), new FlyWithWings())
        {

        }
        public override string Display()
        {
            return "I’m a real Mallard Duck";
        }
    }
}
