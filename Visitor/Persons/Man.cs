using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Persons
{
    internal class Man : Person
    {
        public override void GetConclusion()
        {
            if (Action == "成功")
            {
                Console.WriteLine($"{this.GetType().Name}{Action}時，有一個偉大的女人");
            }
            else if (Action == "失敗")
            {
                Console.WriteLine($"{this.GetType().Name}失敗時，悶頭喝酒");
            }
            else if (Action == "戀愛")
            {
                Console.WriteLine($"{this.GetType().Name}戀愛時，不懂裝懂");
            }
        }
    }
}