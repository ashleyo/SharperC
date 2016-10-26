using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature, humidity, pressure;

        public void measurementsChanged()
        {
            notifyObservors();
        }

        //fakery - use Node.Red or similar to get weather data from Met Office website 
        //you lazy person, you.
        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }   

        public void notifyObservors()
        {
            foreach (IObserver o in observers)
                o.update(temperature, humidity, pressure);
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            observers.RemoveAll(x => Object.ReferenceEquals(x,o));
        }
    }
}
