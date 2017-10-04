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
            IFactory factory = new UndergraduateFactory();
            Nightingle nightingle1 = factory.CreateNightingle();
            nightingle1.BuyRice();

            IFactory factory2 = new VolunteerFactory();
            Nightingle nightingle2 = factory.CreateNightingle();
            nightingle2.BuyRice();
        }
    }
}