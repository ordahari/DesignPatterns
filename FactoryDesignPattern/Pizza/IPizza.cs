using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pizza
{
    public interface IPizza
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
}
