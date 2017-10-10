using Observer.Secretaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.StockObservers
{
    internal class StockObserver
    {
        private string _name;

        private Secretary _secret;

        public StockObserver(string name, Secretary secret)
        {
            this._name = name;
            this._secret = secret;
        }

        public void Update()
        {
            Console.WriteLine("{0} {1} 關閉股票行情，繼續工作", this._secret.SecretyAction, this._name);
        }
    }
}