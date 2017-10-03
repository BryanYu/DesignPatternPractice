using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Fineries
{
    internal class LeatherShoes : Finery
    {
        public override void Show()
        {
            Console.WriteLine("皮鞋");
        }
    }
}