using Bridage.AddressList;
using Bridage.Brand;
using Bridage.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridage
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HandsetBrand hb = new HandsetBrand();
            hb = new HandsetBrandMAddressList();
            hb.Run();

            hb = new HandsetBrandMGame();
            hb.Run();

            hb = new HandsetBrandNAddressList();
            hb.Run();

            hb = new HandsetBrandNGame();
            hb.Run();

            Console.Read();
        }
    }
}