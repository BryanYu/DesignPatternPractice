using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Barbecu
{
    public abstract class Commands
    {
        protected Barbecuer receiver;

        public Commands(Barbecuer receiver)
        {
            this.receiver = receiver;
        }

        public abstract void ExecuteCommand();
    }
}