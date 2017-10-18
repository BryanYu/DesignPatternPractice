using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IEnumerable<int> temps = new List<int> { 1, 2, 3, 4, 5 };

            foreach (var temp in temps)
            {
                Console.WriteLine(temp);
            }
        }
    }
}