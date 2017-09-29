using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Cash
{
    public class CashContext
    {
        private CashSuper _cash;

        public CashContext(CashSuper cash)
        {
            this._cash = cash;
        }

        public double GetResult(double money)
        {
            return _cash.AcceptCash(money);
        }
    }
}