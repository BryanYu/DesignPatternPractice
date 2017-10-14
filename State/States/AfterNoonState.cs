using System;
using State.Works;

namespace State.States
{
    internal class AfterNoonState : AbstactState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 17)
            {
                Console.WriteLine($"當前時間:{work.Hour}點 下午狀態還不錯 繼續");
            }
            else
            {
                work.SetState(new EveningState());
                work.WriteProgram();
            }
        }
    }
}