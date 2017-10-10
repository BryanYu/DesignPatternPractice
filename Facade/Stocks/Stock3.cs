using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Stocks
{
    internal class Stock3
    {
        public void Sell()
        {
            Console.WriteLine("Stock3賣出");
        }

        public void Buy()
        {
            Console.WriteLine("Stock3買入");
        }
    }
}