using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.TestPapers
{
    internal class TestPaperA : TestPaper
    {
        public new void Question1()
        {
            base.Question1();
            Console.WriteLine("答案:B");
        }

        public new void Question2()
        {
            base.Question2();
            Console.WriteLine("答案:A");
        }

        public new void Question3()
        {
            base.Question3();
            Console.WriteLine("答案:D");
        }
    }
}