using Observer.Observer;
using System.Collections.Generic;

namespace Observer.WeatherData
{
    public class WeatherStation : ISubject
    {

        private List<IObserver> observers;
        private WeatherDataResult data;
        public WeatherStation()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            if (observer != null)
            {
                if (observers.Contains(observer))
                {
                    return;
                }
                observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            if (data != null)
            {
                foreach (var item in observers)
                {
                    item.Update(data);
                }
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(int temperature, int humidity, int pressure)
        {
            data = new WeatherDataResult(temperature, humidity, pressure);
            MeasurementsChanged();
        }

    }
}
