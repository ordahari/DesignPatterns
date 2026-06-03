using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Devices;
using Command.Interface;

namespace Command.Commands
{
    public class LightOffCommand : ICommand
    {
        Light _light;
        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Off();
        }

    }
}
