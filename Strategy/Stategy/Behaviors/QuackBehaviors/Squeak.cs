﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Stategy.Behaviors
{
    public class Squeak : IQuackBehavior
    {
        public string Quack()
        {

            return "Squeak";
        }
    }
}
