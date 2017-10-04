using Proxy.Pursuits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var girl = new SchoolGirl() { Name = "正妹" };
            var pursuit = new Pursuit(girl);
            pursuit.GiveDolls();
            pursuit.GiveFlowers();
            pursuit.GiveChocolate();

            Console.Read();
        }
    }
}