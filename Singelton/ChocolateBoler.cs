using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class ChocolateBoler
    {
        private static volatile ChocolateBoler instance;
        private static object syncRoot = new Object();
        private bool empty;
        private bool boiled;
        private ChocolateBoler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoler Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ChocolateBoler();
                    }
                }

                return instance;
            }
        }

        public void Fill()
        {
            if (empty)
            {
                empty = false;
                boiled = true;
                Console.WriteLine("fill the boiler with a milk / chocolate ");
            }
        }

        public void Drain()
        {
            if (!empty && boiled)
            {
                empty = true;
                boiled = false;
                Console.WriteLine("drain the boiled milk and chocolate");
            }
        }

        public void Boiled()
        {
            if (!empty && !boiled)
            {
                boiled = true;
                Console.WriteLine("bring the content to a boil");
            }

        }

        public bool IsBoiled()
        {
            return boiled;
        }

        public bool IsEmpty()
        {
            return empty;
        }
    }
}
