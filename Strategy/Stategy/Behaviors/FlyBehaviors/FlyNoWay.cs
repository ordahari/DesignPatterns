using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
