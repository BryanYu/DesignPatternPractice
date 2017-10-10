using Observer.Observers;
using Observer.StockObservers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Notifies
{
    internal class Secretary : ISubject
    {
        private IList<AbstractObserver> _observers = new List<AbstractObserver>();

        public string SecretyAction { get; set; }

        public string Subjectstate
        {
            get { return SecretyAction; }
            set { SecretyAction = value; }
        }

        public void Attach(AbstractObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(AbstractObserver observer)
        {
            throw new NotImplementedException();
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