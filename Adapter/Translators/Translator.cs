using Adapter.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Translators
{
    internal class Translator : AbstractPlayer
    {
        private ForeignCenter _center = new ForeignCenter();

        public Translator(string name) : base(name)
        {
            this._center.Name = name;
        }

        public override void Attack()
        {
            _center.Attack();
        }

        public override void Defense()
        {
            _center.Defense();
        }
    }
}