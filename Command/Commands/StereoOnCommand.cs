using Command.Devices;
using Command.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class StereoOnCommand : ICommand
    {
        Stereo _stereo;
        public StereoOnCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute() {
            _stereo.On();
        }
    }
}
