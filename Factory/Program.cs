using Factory.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("請輸入數字A");
                string numberA = Console.ReadLine();
                Console.WriteLine("請輸入運算符號(+ - * /)");
                string operate = Console.ReadLine();
                Console.WriteLine("請輸入數字B");
                string numberB = Console.ReadLine();

                var operation = OperationFactory.CreateOperate(operate);
                operation.NumberA = Convert.ToDouble(numberA);
                operation.NumberB = Convert.ToDouble(numberB);

                string result = operation.GetResult().ToString();
                Console.WriteLine("結果是:{0}", result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("錯誤:{0}", ex.Message);
            }
        }
    }
}