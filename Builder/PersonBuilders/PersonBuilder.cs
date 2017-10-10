using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.PersonBuilders
{
    internal abstract class PersonBuilder
    {
        public abstract void BuildHead();

        public abstract void BuildBody();

        public abstract void BuildArmLeft();

        public abstract void BuildArmRight();

        public abstract void BuildLegLeft();

        public abstract void BuildLegRight();
    }
}