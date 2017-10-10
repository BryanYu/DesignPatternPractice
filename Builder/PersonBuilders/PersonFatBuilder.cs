using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.PersonBuilders
{
    internal class PersonFatBuilder : PersonBuilder
    {
        public override void BuildArmLeft()
        {
            Console.WriteLine("建出 胖人的左手");
        }

        public override void BuildArmRight()
        {
            Console.WriteLine("建出 胖人的右手");
        }

        public override void BuildBody()
        {
            Console.WriteLine("建出 胖人的身體");
        }

        public override void BuildHead()
        {
            Console.WriteLine("建出 胖人的頭");
        }

        public override void BuildLegLeft()
        {
            Console.WriteLine("建出 胖人的左腳");
        }

        public override void BuildLegRight()
        {
            Console.WriteLine("建出 胖人的右腳");
        }
    }
}