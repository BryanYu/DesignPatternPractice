using Adapter.Players;
using Adapter.Translators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AbstractPlayer forward = new Fowards("Hill");
            forward.Attack();

            AbstractPlayer guard = new Guard("Bryan");
            guard.Attack();

            AbstractPlayer center = new Translator("Yao");
            center.Attack();
            center.Defense();

            Console.Read();
        }
    }
}