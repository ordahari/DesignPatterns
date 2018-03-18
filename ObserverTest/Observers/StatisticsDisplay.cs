using Observer.Client;
using Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTest.Observers
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private List<WeatherDataResult> dataList;

        public StatisticsDisplay()
        {
            dataList = new List<WeatherDataResult>();
        }
        public void Display()
        {
            var average = CalcAverage();

            Console.WriteLine($"Statistics Display : \n Avg Temperature :{average.avgTemperature} \n Avg Humidity : {average.avgHumidity} \n Avg Pressure : {average.avgPressure}");
        }

        private (int avgTemperature,int avgHumidity ,int avgPressure) CalcAverage()
        {
            int sumTemp = 0;
            int sumHumidity = 0;
            int sumPressure = 0;
            foreach (var item in dataList)
            {
                sumTemp += item.Temperature;
                sumHumidity += item.Humidity;
                sumPressure += item.Pressure;
            }

            var count = dataList.Count;
            int avgTemperature = GetAverage(sumTemp,count);
            int avgHumidity = GetAverage(sumHumidity, count);
            int avgPressure = GetAverage(sumPressure, count);
            return (avgTemperature, avgHumidity, avgPressure);

        }

        private int GetAverage(int sum, int count) {

            return sum != 0 ? sum / count : 0;
        }

        public void Update(WeatherDataResult data)
        {
            if (data != null)
            {
                dataList.Add(data);
            }
            Display();
        }
    }
}
