using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Cash
{
    public class CashFactory
    {
        public static CashSuper CreateCashAccept(CashEnum cashEnum)
        {
            switch (cashEnum)
            {
                case CashEnum.Normal:
                    return new CashNormal();

                case CashEnum.Return:
                    return new CashReturn(300, 100);

                case CashEnum.Rebate:
                    return new CashRebate(0.8);

                default:
                    throw new ArgumentException("參數錯誤");
            }
        }
    }
}