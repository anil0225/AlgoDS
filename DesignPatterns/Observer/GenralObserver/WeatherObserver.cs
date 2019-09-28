using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.GenralObserver
{
    public class WeatherObserver : IObserver
    {
        BaseObservable _subject;

        string _name;

        public WeatherObserver(BaseObservable subject, string name)
        {
            _subject = subject;
            _name = name;
        }
        public void Notify()
        {
            Console.WriteLine(string.Format("Logging Weather Update {0} for observer {1}",_subject.State, _name));
        }
    }
}
