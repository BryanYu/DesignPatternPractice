using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.TestPapers
{
    internal abstract class TestPaper
    {
        public void Question1()
        {
            Console.WriteLine("試題1");
        }

        public void Question2()
        {
            Console.WriteLine("試題2");
        }

        public void Question3()
        {
            Console.WriteLine("試題3");
        }
    }
}