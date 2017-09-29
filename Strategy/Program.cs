using Strategy.Cash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("請選擇收費方式：1.正常收費 2.滿三百送一百 3.打8折");
            var cashType = (CashEnum)Enum.Parse(typeof(CashEnum), Console.ReadLine());

            var cash = new CashContext(cashType);
            Console.WriteLine("請輸入數量:");
            var count = int.Parse(Console.ReadLine());

            Console.WriteLine("請輸入金額：");
            var money = double.Parse(Console.ReadLine());
            var result = cash.GetResult(count * money);

            Console.WriteLine("金額為:{0}", result);
            Console.Read();
        }
    }
}