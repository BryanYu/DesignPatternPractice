using ChainOfResponsibility.Salary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var manager1 = new Manager("經理1");
            var manager2 = new Manager("經理2");
            var manager3 = new Manager("經理3");

            var request1 = new Request();
            request1.RequestType = RequestType.Salary;
            request1.RequestContent = "要求加薪";
            request1.Number = 1000;
            manager1.GetResult(ManagerLevel.Manager, request1);
            manager2.GetResult(ManagerLevel.Director, request1);
            manager3.GetResult(ManagerLevel.GM, request1);

            var request2 = new Request();
            request2.RequestType = RequestType.Vacation;
            request2.RequestContent = "要求請假";
            request2.Number = 3;
            manager1.GetResult(ManagerLevel.Manager, request2);
            manager2.GetResult(ManagerLevel.Director, request2);
            manager3.GetResult(ManagerLevel.GM, request2);

            Console.Read();
        }
    }
}