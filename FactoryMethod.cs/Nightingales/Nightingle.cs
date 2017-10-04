using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Nightingales
{
    internal class Nightingle
    {
        public void Sweep()
        {
            Console.WriteLine("掃地");
        }

        public void Wash()
        {
            Console.WriteLine("洗衣");
        }

        public void BuyRice()
        {
            Console.WriteLine("買米");
        }
    }
}