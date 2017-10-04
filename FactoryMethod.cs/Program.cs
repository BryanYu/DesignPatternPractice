using FactoryMethod.cs.Nightingales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var nightingle = new Undergraduate();
            nightingle.BuyRice();
            nightingle.Sweep();
            nightingle.Wash();
        }
    }
}