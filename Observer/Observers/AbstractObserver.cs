using Observer.Notifies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observers
{
    internal abstract class AbstractObserver
    {
        protected string _name;

        protected ISubject _sub;

        public AbstractObserver(string name, ISubject subject)
        {
            this._name = name;
            this._sub = subject;
        }

        public abstract void Update();
    }
}