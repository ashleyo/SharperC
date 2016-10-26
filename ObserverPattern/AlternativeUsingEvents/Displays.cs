using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeUsingEvents
{
    class CurrentConditionsDisplay : IDisplayElement
    {
        private float temperature, humidity, pressure;
        private IWeatherDataSource weatherData;

        public CurrentConditionsDisplay(IWeatherDataSource WD)
        {
            this.weatherData = WD;
            WD.RaiseNewDataEvent += display;
        }

        public void display(object o, WeatherDataArgs e)
        {
            this.temperature = e.Temperature;
            this.humidity = e.Humidity;
            Console.WriteLine($"Current Conditions: Temp: {temperature:F1}C Humidity: {humidity:F1}%");
        }
    }

    class StatisticalDisplay : IDisplayElement
    {
        private float temperature, humidity, pressure;
        private IWeatherDataSource weatherData;

        public StatisticalDisplay(IWeatherDataSource WD)
        {
            this.weatherData = WD;
            WD.RaiseNewDataEvent += display;
        }

        private float average(float oldval, float newval)
        {
            const int averagingSet = 10;
            return (oldval*(averagingSet-1) + newval)/averagingSet;
        }

        public void display(object o, WeatherDataArgs e)
        {
            this.temperature = average(this.temperature, e.Temperature);
            this.humidity = average(this.humidity, e.Humidity);

            Console.WriteLine($"Current Conditions: Averag temp: {temperature:F1}C Average humidity: {humidity:F1}%");
        }
    }
}
