using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.UN
{
    internal abstract class Country
    {
        protected UnitedNations _meditor;

        public Country(UnitedNations meditor)
        {
            this._meditor = meditor;
        }
    }
}