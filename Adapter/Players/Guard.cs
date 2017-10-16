using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Players
{
    internal class Guard : AbstractPlayer
    {
        public Guard(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"後衛{this._name}進攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"後衛{this._name}防守");
        }
    }
}