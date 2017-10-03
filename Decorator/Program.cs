using Decorator.Fineries;
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

            Finery tShirts = new TShirts();
            Finery bigTrouser = new BigTourser();
            Finery sneakers = new Sneakers();

            tShirts.Decorate(person);
            bigTrouser.Decorate(tShirts);
            sneakers.Decorate(bigTrouser);
            sneakers.Show();

            Console.WriteLine("第二種裝扮");
            Finery suit = new Suit();
            Finery tie = new Tie();
            Finery leatherShoes = new LeatherShoes();
            suit.Decorate(person);
            tie.Decorate(suit);
            leatherShoes.Decorate(tie);
            leatherShoes.Show();

            Console.Read();
        }
    }
}