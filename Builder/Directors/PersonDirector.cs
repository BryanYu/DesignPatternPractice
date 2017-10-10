using Builder.PersonBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    internal class PersonDirector
    {
        private PersonBuilder _builder;

        public PersonDirector(PersonBuilder builder)
        {
            this._builder = builder;
        }

        public void CreatePerson()
        {
            this._builder.BuildHead();
            this._builder.BuildBody();
            this._builder.BuildArmLeft();
            this._builder.BuildArmRight();
            this._builder.BuildLegLeft();
            this._builder.BuildLegRight();
        }
    }
}