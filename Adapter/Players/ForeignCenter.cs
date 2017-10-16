using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Players
{
    internal class ForeignCenter
    {
        public string Name { get; set; }

        public void Attack()
        {
            Console.WriteLine($"外籍中鋒{this.Name}進攻");
        }

        public void Defense()
        {
            Console.WriteLine($"外籍中鋒{this.Name}防守");
        }
    }
}