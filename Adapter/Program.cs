using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var turkey = new WildTurkey();
            var duck = new MallardDuck();

            var ducks = new List<IDuck>
            {
                duck,
                new DuckAdapter(turkey)
            };
            Run(ducks);

            Console.Read();

        }

        private static void Run(List<IDuck> ducks)
        {
            foreach (var duck in ducks)
            {
                duck.Name();
                duck.Fly();
                duck.Quack();
            }
        }
    }
}
