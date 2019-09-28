using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.GenralObserver
{
    public class BaseObservable:IObservable
    {
        private IList<IObserver> observers;

        public string State { get; set; }

        public BaseObservable()
        {
            observers = new List<IObserver>();
        }

        public void AttachObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void DetachObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {

            foreach (var observer in observers)
            {
                observer.Notify();
            }
        }
    }
}
