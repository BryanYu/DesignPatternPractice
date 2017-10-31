using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Persons
{
    internal class Woman : Person
    {
        public override void GetConclusion()
        {
            if (Action == "成功")
            {
                Console.WriteLine($"{this.GetType().Name}{Action}時，有一個不成功的男人");
            }
            else if (Action == "失敗")
            {
                Console.WriteLine($"{this.GetType().Name}失敗時，眼淚汪汪");
            }
            else if (Action == "戀愛")
            {
                Console.WriteLine($"{this.GetType().Name}戀愛時，懂也裝不懂");
            }
        }
    }
}