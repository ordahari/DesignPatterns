using Strategy.Stategy.Behaviors;
using Strategy.Stategy.Behaviors.FlyBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
