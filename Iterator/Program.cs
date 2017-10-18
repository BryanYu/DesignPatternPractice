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
            List<int> temps = new List<int> { 1, 2, 3, 4, 5 };

            //foreach
            foreach (var temp in temps)
            {
                Console.WriteLine(temp);
            }
            //Enumeator
            List<int> temps2 = new List<int> { 6, 7, 8, 9, 10 };
            var tempEnumerator = temps2.GetEnumerator();
            while (tempEnumerator.MoveNext())
            {
                Console.WriteLine(tempEnumerator.Current);
            }
            Console.Read();
        }
    }
}