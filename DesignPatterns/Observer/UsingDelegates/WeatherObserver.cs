using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.UsingDelegates
{
    public class WeatherObserver
    {
        string _name;
        public WeatherObserver(string name) {
            _name = name;
        }
        
        public void NotifyWeatherChange(object sender, string message) {
            Console.WriteLine("Updated weather for {0} , {1}",_name,message);
        }
    }
}
