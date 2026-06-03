using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Interface;

namespace Command.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No Command !!");
        }

    }
}
