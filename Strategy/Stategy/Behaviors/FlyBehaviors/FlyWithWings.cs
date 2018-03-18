using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Stategy.Behaviors.FlyBehaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public string Fly()
        {
            return "flying";
        }
    }
}
