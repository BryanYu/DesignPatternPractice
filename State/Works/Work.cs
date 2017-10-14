using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Works
{
    internal class Work
    {
        public int Hour { get; set; }

        public bool Finish { get; set; }

        public void WriteProgram()
        {
            if (Hour < 12)
            {
                Console.WriteLine($"當前時間:{Hour}點 上午工作 精神百倍");
            }
            else if (Hour < 13)
            {
                Console.WriteLine($"當前時間:{Hour}點 餓了 午飯 午休");
            }
            else if (Hour < 17)
            {
                Console.WriteLine($"當前時間:{Hour}點 下午狀態還不錯 繼續");
            }
            else
            {
                if (Finish)
                {
                    Console.WriteLine($"當前時間:{Hour}點 下班了");
                }
                else
                {
                    if (Hour > 21)
                    {
                        Console.WriteLine($"當前時間:{Hour}點 加班");
                    }
                    else
                    {
                        Console.WriteLine($"當前時間:{Hour}點 不行了");
                    }
                }
            }
        }
    }
}