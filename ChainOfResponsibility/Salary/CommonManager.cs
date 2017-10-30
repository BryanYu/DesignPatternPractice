using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Salary
{
    internal class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {
        }

        public override void RequestApplication(Request request)
        {
            if (request.RequestType == RequestType.Vacation && request.Number <= 2)
            {
                Console.WriteLine($"{_name} : {request.RequestContent} 數量{request.Number} 被批准");
            }
            else
            {
                if (_superior != null)
                {
                    _superior.RequestApplication(request);
                }
            }
        }
    }
}