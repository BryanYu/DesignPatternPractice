using System;
using State.Works;

namespace State.States
{
    internal class EveningState : AbstactState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Finish)
            {
                work.SetState(new RestState());
                work.WriteProgram();
            }
            else
            {
                if (work.Hour < 21)
                {
                    Console.WriteLine($"當前時間:{work.Hour}點 加班");
                }
                else
                {
                    work.SetState(new SleepingState());
                }
            }
        }
    }
}