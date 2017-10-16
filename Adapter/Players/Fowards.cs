using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Players
{
    internal class Fowards : AbstractPlayer
    {
        public Fowards(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"前鋒{this._name}進攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"前鋒{this._name}防守");
        }
    }
}