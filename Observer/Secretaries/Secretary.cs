using Observer.Observers;
using Observer.StockObservers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Secretaries
{
    internal class Secretary
    {
        private IList<AbstractObserver> _observers = new List<AbstractObserver>();

        public string SecretyAction { get; set; }

        public void Attach(AbstractObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Deatch(AbstractObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}