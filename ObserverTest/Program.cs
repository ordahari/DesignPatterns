using Observer.WeatherData;
using System;
using ObserverTest.Observers;
using System.Threading;

namespace ObserverTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var weather = new WeatherStation();
            weather.RegisterObserver(new CurrentConditionsDisplay());
            weather.RegisterObserver(new StatisticsDisplay());
            var r = new Random();
            for (int i = 0; i < 20; i++)
            {
                Console.Clear();
                Console.WriteLine($"Count :{i}");
                weather.SetMeasurements(r.Next(-55, 55), r.Next(10, 90), r.Next(10, 50));
                Thread.Sleep(1500);
                
            }

            Console.Read();
        }
    }
}
