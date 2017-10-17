using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Companies
{
    internal abstract class Company
    {
        protected string name;

        public Company(string name)
        {
            this.name = name;
        }

        public abstract void Add(Company company);

        public abstract void Remove(Company company);

        public abstract void Display(int depth);

        public abstract void LineOfDuty();
    }
}