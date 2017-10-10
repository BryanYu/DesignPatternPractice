using Observer.Notifies;
using Observer.StockObservers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var secret = new Secretary();

            var stockObserver1 = new StockObserver("看股票同事1", secret);
            var stockObserver2 = new StockObserver("看股票同事2", secret);

            secret.Attach(stockObserver1);
            secret.Attach(stockObserver2);

            secret.SecretyAction = "Boss Coming";

            secret.Notify();

            Console.Read();
        }
    }
}