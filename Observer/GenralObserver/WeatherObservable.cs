using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.GenralObserver
{
    public class WeatherObservable : BaseObservable
    {
        public void ChangeWeather()
        {
            //write your specif code
            base.NotifyObservers();
        }
    }
}
