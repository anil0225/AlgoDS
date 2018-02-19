using Observer.UsingDelegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.UsingDelegates
{
    public class BaseObservable 
    {
        public event EventHandler<string> WeatherChanging;


        string _state;

        public void UpdateWeather(string state) {
            _state = state;
            Notify();
        }

        public void Notify()
        {
            if (WeatherChanging != null)
                WeatherChanging.Invoke(this, _state);
        }
    }

   
}
