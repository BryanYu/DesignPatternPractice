using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Salary
{
    internal abstract class Manager
    {
        protected string _name;

        protected Manager _superior;
        public Manager(string name)
        {
            this._name = name;
        }

        public void SetSuperior(Manager superior)
        {
            this._superior = superior;
        }

        abstract public void RequestApplication(Request request);
    }
}