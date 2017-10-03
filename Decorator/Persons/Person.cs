using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Persons
{
    public class Person
    {
        private string _name;

        public Person()
        {
        }

        public Person(string name)
        {
            this._name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("裝扮的{0}", this._name);
        }
    }
}