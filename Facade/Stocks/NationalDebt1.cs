using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Stocks
{
    internal class NationalDebt1
    {
        public void Sell()
        {
            Console.WriteLine("NationalDebt1賣出");
        }

        public void Buy()
        {
            Console.WriteLine("NationalDebt1買入");
        }
    }
}