using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObserver
    {
        void update(float temp, float humidity, float pressure);
    }

    public interface ISubject
    {
        void registerObserver(IObserver o);
        void removeObserver(IObserver o);
        void notifyObservors();
    }
    public interface IDisplayElement
    {
        void display();
    }
    //public interface IWeatherDataPacket
    //{
    //    float Temperature { get; set; }
    //    float Humidity { get; set; }
    //    float Pressure { get; set; }
    //}
}
+