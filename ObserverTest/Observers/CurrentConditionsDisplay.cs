
using System;
using Observer.Client;
using Observer.Observer;

namespace ObserverTest.Observers
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        WeatherDataResult data;
        public void Display()
        {
            if (data != null)
            {
                Console.WriteLine($"Current Conditions Display :\n Temperature :{data.Temperature} \n Humidity :{data.Humidity} \n Pressure :{data.Pressure}");
                return;
            }
            Console.WriteLine("No Data !");
        }
        public void Update(WeatherDataResult data)
        {
            this.data = data;
            Display();
        }
    }
}
