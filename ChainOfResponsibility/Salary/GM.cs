using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Salary
{
    internal class GM : Manager
    {
        public GM(string name) : base(name)
        {
        }

        public override void RequestApplication(Request request)
        {
            if (request.RequestType == RequestType.Vacation)
            {
                Console.WriteLine($"{_name} : {request.RequestContent} 數量{request.Number} 被批准");
            }
            else if (request.RequestType == RequestType.Salary && request.Number <= 500)
            {
                Console.WriteLine($"{_name} : {request.RequestContent} 數量{request.Number} 被批准");
            }
            else if (request.RequestType == RequestType.Salary && request.Number > 500)
            {
                Console.WriteLine($"{_name} : {request.RequestContent} 數量{request.Number} 再說吧");
            }
        }
    }
}