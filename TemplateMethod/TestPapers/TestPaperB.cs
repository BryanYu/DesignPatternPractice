using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.TestPapers
{
    internal class TestPaperB : TestPaper
    {
        public override string Answer1()
        {
            return "C";
        }

        public override string Answer2()
        {
            return "D";
        }

        public override string Answer3()
        {
            return "B";
        }
    }
}