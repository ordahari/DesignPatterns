
using System;
using System.Threading;

namespace Singleton
{
    class Program
    {


        static void Main(string[] args)
        {

            ChocolateBoler chocolateBoler = ChocolateBoler.Instance;

            // Spin up a second thread that also asks for the boiler. Because the
            // class is a Singleton, it must receive the very same instance.
            Thread thread1 = new Thread(SomeThread);
            thread1.Start();
            thread1.Join();

            chocolateBoler.Fill();
            Console.WriteLine("IsEmpty:" + chocolateBoler.IsEmpty());
            Console.WriteLine("IsBoiled:" + chocolateBoler.IsBoiled());
            chocolateBoler.Boiled();
            Console.WriteLine("IsEmpty:" + chocolateBoler.IsEmpty());
            Console.WriteLine("IsBoiled:" + chocolateBoler.IsBoiled());
            chocolateBoler.Drain();
            Console.WriteLine("IsEmpty:" + chocolateBoler.IsEmpty());
            Console.WriteLine("IsBoiled:" + chocolateBoler.IsBoiled());
        }

        public static void SomeThread(object? obj)
        {
            var _chocolateBoler = ChocolateBoler.Instance;
            bool sameInstance = ReferenceEquals(_chocolateBoler, ChocolateBoler.Instance);
            Console.WriteLine("SomeThread got the same instance: " + sameInstance);
        }
    }
}
