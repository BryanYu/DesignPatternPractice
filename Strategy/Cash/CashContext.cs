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

        public CashContext(CashEnum cashEnum)
        {
            switch (cashEnum)
            {
                case CashEnum.Normal:
                    this._cash = new CashNormal();
                    break;

                case CashEnum.Return:
                    this._cash = new CashReturn(300, 100);
                    break;

                case CashEnum.Rebate:
                    this._cash = new CashRebate(0.8);
                    break;

                default:
                    throw new ArgumentException("參數錯誤");
            }
        }

        public double GetResult(double money)
        {
            return _cash.AcceptCash(money);
        }
    }
}