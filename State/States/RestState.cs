using System;
using State.Works;

namespace State.States
{
    internal class RestState : AbstactState
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine($"當前時間:{work.Hour}點 下班回家");
        }
    }
}