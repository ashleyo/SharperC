using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeUsingEvents
{
    public class WeatherDataArgs : EventArgs
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public WeatherDataArgs(float temp, float humidity, float pressure)
        {
            Temperature = temp; Humidity = humidity; Pressure = pressure;
        }
    }

    public class WeatherData: IWeatherDataSource
    {
        public event EventHandler<WeatherDataArgs> RaiseNewDataEvent;

        //fakery - use Node.Red or similar to get weather data from Met Office website 
        //you lazy person, you.
        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            if (RaiseNewDataEvent != null)
                RaiseNewDataEvent(this, new WeatherDataArgs(temperature,humidity,pressure));
        }
    }
}
