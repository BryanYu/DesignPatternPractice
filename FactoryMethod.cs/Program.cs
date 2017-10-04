using FactoryMethod.Nightingales;
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
            var nightingle1 = SimpleFactory.CreateNightingle(RoleType.Student);
            nightingle1.BuyRice();
            var nightingle2 = SimpleFactory.CreateNightingle(RoleType.Volunteer);
            nightingle2.Sweep();
            var nightingle3 = SimpleFactory.CreateNightingle(RoleType.Student);
            nightingle3.Wash();
        }
    }
}