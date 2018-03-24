using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Devices
{
    public class Stereo
    {
        bool on = false;
        int _volume = 0;
        public void On()
        {
            on = true;
            _volume = 1;
            Console.WriteLine("--Stereo Is On !!");
        }
        public void Off()
        {
            on = false;
            _volume = 0;
            Console.WriteLine("--Stereo Is Off !!");

        }

        public void VolumeUp()
        {
            if (on)
            {
                ++_volume;
                Console.WriteLine($"--Stereo Volume Is: {_volume}");
            }
            else
            {
                Console.WriteLine("--Stereo Is OFF");
            }

        }
        public void VolumeDown()
        {
            if (on)
            {
                --_volume;
                Console.WriteLine($"--Stereo Volume Is: {_volume}");
            }
            else
            {
                Console.WriteLine("--Stereo Is OFF");
            }
        }

    }
}
