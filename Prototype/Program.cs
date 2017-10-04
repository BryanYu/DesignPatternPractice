using Prototype.Resumes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var resume = new Resume("Bryan");
            resume.SetPersonalInfo("男", "28");
            resume.SetWorkExperience("1998-2000", "XX公司");

            var resume2 = (Resume)resume.Clone();
            resume2.SetWorkExperience("1998-2006", "YY公司");

            var resume3 = (Resume)resume.Clone();
            resume3.SetPersonalInfo("男", "25");

            resume.Display();
            resume2.Display();
            resume3.Display();

            Console.Read();
        }
    }
}