using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Persons
{
    internal abstract class Action
    {
        public abstract void GetManConclusion(Man concreteElementA);

        public abstract void GetWoManConclusion(Woman concreteElementA);
    }
}