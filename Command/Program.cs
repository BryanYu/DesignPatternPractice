using Command.Barbecu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var boy = new Barbecuer();
            boy.BakeMutton();
            boy.BakeChickenWing();
            boy.BakeMutton();
            boy.BakeMutton();
            boy.BakeMutton();
            boy.BakeChickenWing();
            Console.Read();
        }
    }
}