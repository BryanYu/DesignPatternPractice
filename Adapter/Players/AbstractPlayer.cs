using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Players
{
    internal abstract class AbstractPlayer
    {
        protected string _name;

        public AbstractPlayer(string name)
        {
            this._name = name;
        }

        public abstract void Attack();

        public abstract void Defense();
    }
}