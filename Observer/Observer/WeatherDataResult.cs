namespace Observer.Observer
{
    public class WeatherDataResult
    {

        private int _temperature;
        private int _humidity;
        private int _pressure;

        public WeatherDataResult(int temperature, int humidity, int pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
        }
        public int Temperature
        {
            get { return _temperature; }

        }

        public int Humidity
        {
            get { return _humidity; }

        }

        public int Pressure
        {
            get { return _pressure; }

        }

    }
}
