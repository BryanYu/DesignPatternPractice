using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Persons
{
    internal abstract class Person
    {
        public string Action { get; set; }

        public abstract void GetConclusion();
    }
}