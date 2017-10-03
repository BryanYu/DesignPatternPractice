using Decorator.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Fineries
{
    internal class Finery : Person
    {
        protected Person _component;

        public void Decorate(Person component)
        {
            this._component = component;
        }

        public override void Show()
        {
            if (this._component != null)
            {
                this._component.Show();
            }
        }
    }
}