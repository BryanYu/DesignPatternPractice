using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Salary
{
    internal class Request
    {
        public RequestType RequestType { get; set; }

        public string RequestContent { get; set; }

        public int Number { get; set; }
    }
}