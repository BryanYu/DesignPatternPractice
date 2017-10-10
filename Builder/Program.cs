using Builder.Directors;
using Builder.PersonBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var thinBulider = new PersonThinBuilder();
            var thinDirector = new PersonDirector(thinBulider);
            thinDirector.CreatePerson();

            var fatBulider = new PersonFatBuilder();
            var fatDirector = new PersonDirector(fatBulider);
            fatDirector.CreatePerson();

            Console.Read();
        }
    }
}