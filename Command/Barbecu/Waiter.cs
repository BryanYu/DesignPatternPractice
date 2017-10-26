using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Barbecu
{
    internal class Waiter
    {
        private Commands _command;

        public void SetOrder(Commands command)
        {
            this._command = command;
        }

        public void Notify()
        {
            this._command.ExecuteCommand();
        }
    }
}