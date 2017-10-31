using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Site
{
    internal class WebSite
    {
        private string _name;

        public WebSite(string name)
        {
            this._name = name;
        }

        public void Use()
        {
            Console.WriteLine($"網站分類{this._name}");
        }
    }
}