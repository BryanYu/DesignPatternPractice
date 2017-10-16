using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Players
{
    internal class Center : AbstractPlayer
    {
        public Center(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"中鋒{this._name}進攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"中鋒{this._name}防守");
        }
    }
}