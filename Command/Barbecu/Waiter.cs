using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Barbecu
{
    internal class Waiter
    {
        private List<Commands> _orders = new List<Commands>();

        public void SetOrder(Commands command)
        {
            if (command.ToString() == "命令模式.BakeChickenWingCommand")
            {
                Console.WriteLine("雞翅沒有了");
            }
            else
            {
                _orders.Add(command);
                Console.WriteLine("增加訂單:" + command.ToString() + "時間:" + DateTime.Now.ToString());
            }
        }

        public void CancelOrder(Commands command)
        {
            this._orders.Remove(command);
            Console.WriteLine("取消訂單:" + command.ToString() + "時間:" + DateTime.Now.ToString());
        }

        public void Notify()
        {
            foreach (var order in this._orders)
            {
                order.ExecuteCommand();
            }
        }
    }
}