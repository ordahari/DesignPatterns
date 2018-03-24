using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class DuckAdapter : IDuck
    {
        ITurkey _turkey;
        public DuckAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }

        }

        public void Name()
        {
            Console.WriteLine(_turkey.GetType().Name);
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}
