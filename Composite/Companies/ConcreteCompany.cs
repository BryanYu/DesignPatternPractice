using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Companies
{
    internal class ConcreteCompany : Company
    {
        private List<Company> _children = new List<Company>();

        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company company)
        {
            this._children.Add(company);
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)} {name}");

            foreach (var component in this._children)
            {
                component.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (var component in this._children)
            {
                component.LineOfDuty();
            }
        }

        public override void Remove(Company company)
        {
            this._children.Remove(company);
        }
    }
}