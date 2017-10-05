using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.TestPapers
{
    internal class TestPaperA : TestPaper
    {
        public override string Answer1()
        {
            return "A";
        }

        public override string Answer2()
        {
            return "B";
        }

        public override string Answer3()
        {
            return "C";
        }
    }
}