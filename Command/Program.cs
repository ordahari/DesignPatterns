using Command.Commands;
using Command.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new RemoteControl();
            var light = new Light();
            r.SetCommand(0, new LightOnCommand(light), new LightOffCommand(light));
            var stereo = new Stereo();
            r.SetCommand(1, new StereoOnCommand(stereo), new StereoOffCommand(stereo));
            r.SetCommand(2, new StereoVolumeUpCommand(stereo), new StereoVolumeDownCommand(stereo));
            r.Display();
            r.OnButtonWasPushed(0);
            r.OffButtonWasPushed(0);
            r.OnButtonWasPushed(1);
            r.OffButtonWasPushed(2);
            r.OnButtonWasPushed(2);
            r.OffButtonWasPushed(1);
            r.OnButtonWasPushed(2);
            r.OffButtonWasPushed(2);
            Console.Read();
        }
    }
}
