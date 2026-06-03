using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Devices;
using Command.Interface;

namespace Command.Commands
{
    public class StereoVolumeDownCommand : ICommand
    {
        Stereo _stereo;
        public StereoVolumeDownCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.VolumeDown();
        }
    }
}
