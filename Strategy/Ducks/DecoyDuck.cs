using Strategy.Stategy.Behaviors;
using Strategy.Stategy.Behaviors.FlyBehaviors;

namespace Strategy.Ducks
{
    public class DecoyDuck : BaseDuck
    {

        public DecoyDuck() : base(new MuteQuack(), new FlyNoWay())
        {

        }
        public override string Display()
        {
            return "I’m a Decoy Duck";
        }
    }
}
