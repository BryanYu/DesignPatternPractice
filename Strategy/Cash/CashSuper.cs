using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Strategy.Cash
{
    /// <summary>
    /// 現金收費抽象類別
    /// </summary>
    public abstract class CashSuper
    {
        public abstract double AcceptCash(double money);
    }
}