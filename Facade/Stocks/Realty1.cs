using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Stocks
{
    internal class Realty1
    {
        public void Sell()
        {
            Console.WriteLine("Realty1賣出");
        }

        public void Buy()
        {
            Console.WriteLine("Realty1買入");
        }
    }
}