using Facade.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Funds
{
    internal class Fund
    {
        private Stock1 _stock1 { get; set; }
        private Stock2 _stock2 { get; set; }
        private Stock3 _stock3 { get; set; }

        private NationalDebt1 _nationalDebt1 { get; set; }

        private Realty1 _realty1 { get; set; }

        public Fund()
        {
            this._stock1 = new Stock1();
            this._stock2 = new Stock2();
            this._stock3 = new Stock3();
            this._nationalDebt1 = new NationalDebt1();
            this._realty1 = new Realty1();
        }

        public void BuyFund()
        {
            this._stock1.Buy();
            this._stock2.Buy();
            this._stock3.Buy();
            this._nationalDebt1.Buy();
            this._realty1.Buy();
        }

        public void SellFund()
        {
            this._stock1.Sell();
            this._stock2.Sell();
            this._stock3.Sell();
            this._nationalDebt1.Sell();
            this._realty1.Sell();
        }
    }
}