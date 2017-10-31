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
            var persons = new List<Person>();
            persons.Add(new Man { Action = "成功" });
            persons.Add(new Woman { Action = "成功" });
            persons.Add(new Man { Action = "失敗" });
            persons.Add(new Woman { Action = "失敗" });
            persons.Add(new Man { Action = "戀愛" });
            persons.Add(new Woman { Action = "戀愛" });

            foreach (var person in persons)
            {
                person.GetConclusion();
            }

            Console.Read();
        }
    }
}