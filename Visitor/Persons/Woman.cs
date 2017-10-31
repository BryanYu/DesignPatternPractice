using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Persons
{
    internal class Woman : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetWoManConclusion(this);
        }
    }
}