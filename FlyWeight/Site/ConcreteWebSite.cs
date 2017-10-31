using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Site
{
    internal class ConcreteWebSite : WebSite
    {
        private string _name;

        public ConcreteWebSite(string name)
        {
            this._name = name;
        }

        public override void Use(User user)
        {
            Console.WriteLine($"網站分類:{this._name},使用者:{user.Name}");
        }
    }
}