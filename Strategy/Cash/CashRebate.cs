using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Cash
{
    /// <summary>
    /// 打折收費類別
    /// </summary>
    public class CashRebate : CashSuper
    {
        private double _moneyRebate = 1d;

        public CashRebate(double moneyRebate)
        {
            this._moneyRebate = moneyRebate;
        }

        public override double AcceptCash(double money)
        {
            return money * this._moneyRebate;
        }
    }
}