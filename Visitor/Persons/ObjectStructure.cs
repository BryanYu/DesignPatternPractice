using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Persons
{
    internal class ObjectStructure
    {
        private List<Person> _elements = new List<Person>();

        public void Attach(Person element)
        {
            this._elements.Add(element);
        }

        public void Detach(Person element)
        {
            this._elements.Remove(element);
        }

        public void Display(Action visitor)
        {
            foreach (var e in _elements)
            {
                e.Accept(visitor);
            }
        }
    }
}