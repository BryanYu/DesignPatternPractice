using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Persons;

namespace Visitor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ObjectStructure obj = new ObjectStructure();
            obj.Attach(new Man());
            obj.Attach(new Woman());

            Success success = new Success();
            obj.Display(success);

            Fail fail = new Fail();
            obj.Display(fail);

            Love love = new Love();
            obj.Display(love);

            Console.Read();
        }
    }
}