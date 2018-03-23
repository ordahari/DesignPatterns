
using System;
using System.Threading;

namespace Singleton
{
    class Program
    {


        static void Main(string[] args)
        {

            ChocolateBoler chocolateBoler = ChocolateBoler.Instance;

            Thread thread1 = new Thread(SomeThread);
            thread1.Start();
            chocolateBoler.Fill();
            Console.WriteLine("IsEmpty:" + chocolateBoler.IsEmpty());
            Console.WriteLine("IsBoiled:" + chocolateBoler.IsBoiled());
            chocolateBoler.Boiled();
            Console.WriteLine("IsEmpty:" + chocolateBoler.IsEmpty());
            Console.WriteLine("IsBoiled:" + chocolateBoler.IsBoiled());
            chocolateBoler.Drain();
            Console.WriteLine("IsEmpty:" + chocolateBoler.IsEmpty());
            Console.WriteLine("IsBoiled:" + chocolateBoler.IsBoiled());

            Console.Read();
        }

        public static void SomeThread(object obj)
        {
            var _chocolateBoler = ChocolateBoler.Instance;
            while (_chocolateBoler.IsBoiled())
            {


            }
            Console.WriteLine("END SomeThread");
        }
    }
}
