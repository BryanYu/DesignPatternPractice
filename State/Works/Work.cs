using State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Works
{
    internal class Work
    {
        private AbstactState _state;

        public int Hour { get; set; }

        public bool Finish { get; set; }

        public Work()
        {
            this._state = new ForenoonState();
        }

        public void WriteProgram()
        {
            _state.WriteProgram(this);
        }

        public void SetState(AbstactState state)
        {
            this._state = state;
        }
    }
}