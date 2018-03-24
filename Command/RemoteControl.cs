using Command.Commands;
using Command.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class RemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            //TODO : Add Validation 

            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }


        public void OnButtonWasPushed(int slot)
        {
            // TODO : ADD validation 
            onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            // TODO : ADD validation 
            offCommands[slot].Execute();
        }

        public void Display()
        {
            Console.WriteLine("Controls:");
            for (int i = 0; i < 7; i++)
            {
                var onType = onCommands[i].GetType();
                var offType = offCommands[i].GetType();

                Console.WriteLine($"[slot:{i}] - [ON:{onType.Name}] - [OFF:{offType.Name}]");
            }
        }
    }
}
