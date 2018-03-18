using Strategy.Stategy.Behaviors;
using Strategy.Stategy.Behaviors.FlyBehaviors;

namespace Strategy.Ducks
{
    public class RedheadDuck :BaseDuck
    {
        public RedheadDuck() : base(new RegularQuacking(), new FlyWithWings())
        {

        }

        public override string Display()
        {
            return "I’m a real Redhead Duck";
        }
    }
}
