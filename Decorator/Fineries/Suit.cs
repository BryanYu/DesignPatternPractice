using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Fineries
{
    internal class Suit : Finery
    {
        public override void Show()
        {
            Console.WriteLine("西裝");
        }
    }
}