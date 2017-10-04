using Proxy.Pursuits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Proxies
{
    public class Proxy : IGiveGift
    {
        private Pursuit _pursuit;

        public Proxy(SchoolGirl girl)
        {
            this._pursuit = new Pursuit(girl);
        }

        public void GiveDolls()
        {
            this._pursuit.GiveDolls();
        }

        public void GiveFlowers()
        {
            this._pursuit.GiveFlowers();
        }

        public void GiveChocolate()
        {
            this._pursuit.GiveChocolate();
        }
    }
}