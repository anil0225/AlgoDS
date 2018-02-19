using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.UsingDelegates
{
    public interface IObservable
    {
        event EventHandler<string> WeatherChanging;
        void Notify();
    }
}
