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
            Console.WriteLine("答案：" + this.Answer1());
        }

        public void Question2()
        {
            Console.WriteLine("試題2");
            Console.WriteLine("答案：" + this.Answer2());
        }

        public void Question3()
        {
            Console.WriteLine("試題3");
            Console.WriteLine("答案：" + this.Answer3());
        }

        public virtual string Answer1()
        {
            return string.Empty;
        }

        public virtual string Answer2()
        {
            return string.Empty;
        }

        public virtual string Answer3()
        {
            return string.Empty;
        }
    }
}