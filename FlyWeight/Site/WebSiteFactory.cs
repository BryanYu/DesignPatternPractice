using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Site
{
    internal class WebSiteFactory
    {
        private Dictionary<string, ConcreteWebSite> _flyWeights = new Dictionary<string, ConcreteWebSite>();

        public WebSite GetWebSiteCategory(string key)
        {
            if (!_flyWeights.ContainsKey(key))
            {
                _flyWeights.Add(key, new ConcreteWebSite(key));
            }
            return this._flyWeights[key];
        }

        public int GetWebSiteCount()
        {
            return _flyWeights.Count();
        }
    }
}