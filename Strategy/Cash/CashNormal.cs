using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Strategy.Cash
{
    /// <summary>
    /// 正常收費類別
    /// </summary>
    public class CashNormal : CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}