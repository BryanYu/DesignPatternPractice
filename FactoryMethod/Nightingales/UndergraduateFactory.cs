using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Nightingales
{
    internal class UndergraduateFactory : IFactory
    {
        public Nightingle CreateNightingle()
        {
            return new Undergraduate();
        }
    }
}