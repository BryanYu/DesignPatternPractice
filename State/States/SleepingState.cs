using System;
using State.Works;

namespace State.States
{
    internal class SleepingState : AbstactState
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine($"當前時間:{work.Hour}點 睡著了");
        }
    }
}