using Observer.Observers;
using Observer.Secretaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.NBAObservers
{
    internal class NBAObserver : AbstractObserver
    {
        public NBAObserver(string name, Secretary secret) : base(name, secret)
        {
        }

        public override void Update()
        {
            Console.WriteLine("{0} {1} 關閉NBA，繼續工作", this._secret.SecretyAction, this._name);
        }
    }
}