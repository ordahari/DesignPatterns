using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Devices
{
   public class Light
    {
        public void On()
        {
            Console.WriteLine("Light Is On ");
        }

        public void Off()
        {
            Console.WriteLine("Light Is Off ");
        }
    }
}
