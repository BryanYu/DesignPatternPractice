using FlyWeight.Site;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var webSite1 = new WebSite("產品展示");
            webSite1.Use();

            var webSite2 = new WebSite("產品展示");
            webSite2.Use();

            var webSite3 = new WebSite("產品展示");
            webSite3.Use();

            var webSite4 = new WebSite("部落格");
            webSite4.Use();

            var webSite5 = new WebSite("部落格");
            webSite5.Use();

            var webSite6 = new WebSite("部落格");
            webSite6.Use();

            Console.Read();
        }
    }
}