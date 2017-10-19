using Bridage.Brand;
using Bridage.Soft;
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
            HandsetBrand hb;
            hb = new HandsetBrandN();
            hb.SetHandsetSoft(new HandsetGame());
            hb.Run();

            hb = new HandsetBrandM();
            hb.SetHandsetSoft(new HandsetGame());
            hb.Run();

            hb.SetHandsetSoft(new HandsetAddressList());
            hb.Run();
            Console.Read();
        }
    }
}