namespace Strategy.Stategy.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public string Quack()
        {
            return "can’t quack!";
        }
    }
}
