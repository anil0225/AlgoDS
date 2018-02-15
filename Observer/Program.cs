using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic way 
            GenralObserver.Subject weatherSubject = new GenralObserver.WeatherSubject();
            weatherSubject.AttachObserver(new GenralObserver.WeatherObserver(weatherSubject, "Observer1"));
            weatherSubject.AttachObserver(new GenralObserver.WeatherObserver(weatherSubject, "Observer2"));
            weatherSubject.AttachObserver(new GenralObserver.WeatherObserver(weatherSubject, "Observer3"));
            weatherSubject.AttachObserver(new GenralObserver.WeatherObserver(weatherSubject, "Observer4"));
            weatherSubject.State = "New Weather Report";
            weatherSubject.NotifyObservers();
            weatherSubject.State = "Critical Weather Report";
            weatherSubject.NotifyObservers();

            Console.WriteLine("Enter new Weather Report");
            var weatherStatement = Console.ReadLine();

            weatherSubject.State = weatherStatement;
            weatherSubject.NotifyObservers();

            Console.ReadLine();
            #endregion


            #region using Delegates and events

            #region

        }
    }
}
