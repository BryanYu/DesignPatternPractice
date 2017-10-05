using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.TestPapers;

namespace TemplateMethod
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("學生A抄的試卷");
            var testPaperA = new TestPaperA();
            testPaperA.Question1();
            testPaperA.Question2();
            testPaperA.Question3();

            Console.WriteLine("學生B抄的試卷");
            var testPaperB = new TestPaperB();
            testPaperB.Question1();
            testPaperB.Question2();
            testPaperB.Question3();

            Console.Read();
        }
    }
}