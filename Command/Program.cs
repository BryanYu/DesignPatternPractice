using Command.Barbecu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var boy = new Barbecuer();
            Commands bakeMuttonCommand1 = new BakeMuttonCommand(boy);
            Commands bakeMuttonCommand2 = new BakeMuttonCommand(boy);
            Commands bakeChickenWingCommand1 = new BakeChickenWing(boy);

            Waiter girl = new Waiter();
            girl.SetOrder(bakeMuttonCommand1);
            girl.Notify();
            girl.SetOrder(bakeMuttonCommand2);
            girl.Notify();
            girl.SetOrder(bakeChickenWingCommand1);
            girl.Notify();

            Console.Read();
        }
    }
}