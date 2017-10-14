using State.Works;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    internal abstract class AbstactState
    {
        public abstract void WriteProgram(Work work);
    }
}