using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Cash
{
    public enum CashEnum
    {
        /// <summary>
        /// 正常收費
        /// </summary>
        Normal = 1,

        /// <summary>
        /// 滿額送
        /// </summary>
        Return = 2,

        /// <summary>
        /// 打折收費
        /// </summary>
        Rebate = 3
    }
}