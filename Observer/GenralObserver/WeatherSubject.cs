using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.GenralObserver
{
    public class WeatherSubject : Subject
    {
        public string State { get; set; }

        public string GetState() {
            return State;
        }
    }
}
