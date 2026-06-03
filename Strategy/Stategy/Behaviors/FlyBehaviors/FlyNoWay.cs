namespace Strategy.Stategy.Behaviors.FlyBehaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public string Fly()
        {
            return "can’t fly!";
        }
    }
}
