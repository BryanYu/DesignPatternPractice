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
            var stock1 = new Stock1();
            var stock2 = new Stock2();
            var stock3 = new Stock3();
            var nationalDebt1 = new NationalDebt1();
            var realty1 = new Realty1();

            stock1.Buy();
            stock2.Buy();
            stock3.Buy();
            nationalDebt1.Buy();
            realty1.Buy();

            stock1.Sell();
            stock2.Sell();
            stock3.Sell();
            nationalDebt1.Sell();
            realty1.Sell();
        }
    }
}