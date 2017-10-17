using Composite.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ConcreteCompany root = new ConcreteCompany("總公司");
            root.Add(new HRDepartment("總公司人力資源部"));
            root.Add(new FinanceDepartment("總公司財務部"));
            ConcreteCompany comp = new ConcreteCompany("分公司");
            comp.Add(new HRDepartment("分公司人力資源部"));
            comp.Add(new FinanceDepartment("分公司財務部"));
            root.Add(comp);

            ConcreteCompany comp1 = new ConcreteCompany("辦事處");
            comp1.Add(new HRDepartment("辦事處人力資源部"));
            comp1.Add(new FinanceDepartment("辦事處財務部"));
            root.Add(comp1);

            ConcreteCompany comp2 = new ConcreteCompany("代表處");
            comp2.Add(new HRDepartment("代表處人力資源部"));
            comp2.Add(new FinanceDepartment("代表處財務部"));
            root.Add(comp2);

            Console.WriteLine("結構圖");
            root.Display(1);

            Console.WriteLine("職責");
            root.LineOfDuty();

            Console.Read();
        }
    }
}