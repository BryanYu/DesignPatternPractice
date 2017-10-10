using Facade.Funds;
using Facade.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var fund = new Fund();
            fund.BuyFund();
            fund.SellFund();
            Console.Read();
        }
    }
}