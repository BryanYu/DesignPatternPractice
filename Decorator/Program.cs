using Decorator.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person("Bryan");

            Console.WriteLine("第一種裝扮");
            person.WearTShirts();
            person.WearBigTrouser();
            person.WearSneakers();
            person.Show();

            Console.WriteLine("第二種裝扮");
            person.WearSuit();
            person.WearTie();
            person.WearLeatherShoes();
            person.Show();
            Console.Read();
        }
    }
}