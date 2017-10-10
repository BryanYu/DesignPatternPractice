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
        private IList<StockObserver> _observers = new List<StockObserver>();

        public string SecretyAction { get; set; }

        public void Attach(StockObserver stockObserver)
        {
            this._observers.Add(stockObserver);
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