using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Salary
{
    internal class Manager
    {
        protected string _name;

        public Manager(string name)
        {
            this._name = name;
        }

        public void GetResult(ManagerLevel level, Request request)
        {
            if (level == ManagerLevel.Manager)
            {
                if (request.RequestType == RequestType.Vacation && request.Number <= 2)
                {
                    Console.WriteLine($"{_name} : {request.RequestContent} 數量{request.Number} 被批准");
                }
                else
                {
                    Console.WriteLine($"{_name} : {request.RequestContent} 數量{request.Number} 我無權處理");
                }
            }
            else if (level == ManagerLevel.Director)
            {
                if (request.RequestType == RequestType.Vacation && request.Number <= 5)
                {
                    Console.WriteLine($"{_name} : {request.RequestContent} 數量{request.Number} 被批准");
                }
                else
                {
                    Console.WriteLine($"{_name} : {request.RequestContent} 數量{request.Number} 我無權處理");
                }
            }
            else if (level == ManagerLevel.GM)
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
}