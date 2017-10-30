using Mediator.UN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var unsc = new UnitedNationSecurityCouncil();
            var usa = new USA(unsc);
            var iraq = new Irag(unsc);

            unsc.Colleague1 = usa;
            unsc.Colleague2 = iraq;

            usa.Declare("123");
            iraq.Declare("456");
            Console.Read();
        }
    }
}