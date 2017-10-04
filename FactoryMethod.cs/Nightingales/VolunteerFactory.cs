using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Nightingales
{
    internal class VolunteerFactory : IFactory
    {
        public Nightingle CreateNightingle()
        {
            return new Volunteer();
        }
    }
}