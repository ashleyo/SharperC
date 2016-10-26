using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class CurrentConditionsDisplay: IObserver, IDisplayElement
    {
        private float temperature, humidity, pressure;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject WD)
        {
            this.weatherData = WD;
            weatherData.registerObserver(this);
        }

        ~CurrentConditionsDisplay()
        {
            weatherData.removeObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine($"Current Conditions: Temp: {temperature:F1}C Humidity: {humidity:F1}%");
        }
    }

    class StatisticalDisplay : IObserver, IDisplayElement
    {
        private float temperature, humidity, pressure;
        private ISubject weatherData;

        public StatisticalDisplay(ISubject WD)
        {
            this.weatherData = WD;
            weatherData.registerObserver(this);
        }

        ~StatisticalDisplay()
        {
            weatherData.removeObserver(this);
        }

        private float average(float oldval, float newval)
        {
            const int averagingSet = 10;
            return (oldval*(averagingSet-1) + newval)/averagingSet;
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = average(this.temperature, temperature);
            this.humidity = average(this.humidity, humidity);
            display();
        }

        public void display()
        {
            Console.WriteLine($"Current Conditions: Averag temp: {temperature:F1}C Average humidity: {humidity:F1}%");
        }
    }
}
