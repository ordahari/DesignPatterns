using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MallardDuck : IDuck
    {
        public void Fly() {
            Console.WriteLine("I'm flaying !!");
        }

        public void Name() {
            Console.WriteLine("Mallard Duck");
        }

        public void Quack() {
            Console.WriteLine("Quack");
        }
    }
}
