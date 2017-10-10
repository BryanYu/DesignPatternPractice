using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Stocks
{
    internal class Stock2
    {
        public void Sell()
        {
            Console.WriteLine("Stock2賣出");
        }

        public void Buy()
        {
            Console.WriteLine("Stock2買入");
        }
    }
}