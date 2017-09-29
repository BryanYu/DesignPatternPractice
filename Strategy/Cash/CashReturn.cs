using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Cash
{
    public class CashReturn : CashSuper
    {
        private double _moneyCondition = 0.0d;

        private double _moneyReturn = 0.0d;

        public CashReturn(double moneyCondition, double moneyReturn)
        {
            this._moneyCondition = moneyCondition;
            this._moneyReturn = moneyReturn;
        }

        public override double AcceptCash(double money)
        {
            double result = money;
            if (money >= _moneyCondition)
            {
                result = money - Math.Floor(money / _moneyCondition) * _moneyReturn;
            }
            return result;
        }
    }
}