using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Pursuits
{
    public class Pursuit
    {
        private SchoolGirl _girl;

        public Pursuit(SchoolGirl girl)
        {
            this._girl = girl;
        }

        public void GiveDolls()
        {
            Console.WriteLine(this._girl.Name + "送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(this._girl.Name + "送你鮮花");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(this._girl.Name + "送你巧克力");
        }
    }
}