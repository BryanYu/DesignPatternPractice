using System;
using State.Works;

namespace State.States
{
    internal class NoonState : AbstactState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 13)
            {
                Console.WriteLine($"當前時間:{work.Hour}點 餓了 午飯 午休");
            }
            else
            {
                work.SetState(new AfterNoonState());
                work.WriteProgram();
            }
        }
    }
}