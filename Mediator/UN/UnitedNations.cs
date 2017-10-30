using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.UN
{
    internal abstract class UnitedNations
    {
        public abstract void Declare(string message, Country colleague);
    }
}