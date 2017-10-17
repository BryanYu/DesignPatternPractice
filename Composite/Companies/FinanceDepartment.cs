using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Companies
{
    internal class FinanceDepartment : Company
    {
        public FinanceDepartment(string name) : base(name)
        {
        }

        public override void Add(Company company)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)} {name}");
        }

        public override void LineOfDuty()
        {
            Console.WriteLine($"{name} 公司財務收支管理");
        }

        public override void Remove(Company company)
        {
        }
    }
}