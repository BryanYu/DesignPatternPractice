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
            WebSiteFactory factory = new WebSiteFactory();
            WebSite website1 = factory.GetWebSiteCategory("產品展示");
            website1.Use();

            WebSite website2 = factory.GetWebSiteCategory("產品展示");
            website2.Use();

            WebSite webSite3 = factory.GetWebSiteCategory("產品展示");
            webSite3.Use();

            WebSite webSite4 = factory.GetWebSiteCategory("部落格");
            webSite4.Use();

            WebSite webSite5 = factory.GetWebSiteCategory("部落格");
            webSite5.Use();

            WebSite webSite6 = factory.GetWebSiteCategory("部落格");
            webSite6.Use();

            var result = factory.GetWebSiteCount();

            Console.WriteLine("網站種類:" + result);

            Console.Read();
        }
    }
}