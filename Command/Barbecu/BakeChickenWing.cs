using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Barbecu
{
    internal class BakeChickenWing : Commands
    {
        public BakeChickenWing(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExecuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}