using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Stocks
{
    internal class Stock1
    {
        public void Sell()
        {
            Console.WriteLine("Stock1賣出");
        }

        public void Buy()
        {
            Console.WriteLine("Stock1買入");
        }
    }
}