using Observer.Secretaries;
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

        protected Secretary _secret;

        public AbstractObserver(string name, Secretary secret)
        {
            this._name = name;
            this._secret = secret;
        }

        public abstract void Update();
    }
}