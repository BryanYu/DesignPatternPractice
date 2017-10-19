using Bridage.Soft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridage.Brand
{
    internal abstract class HandsetBrand
    {
        protected HandSoft _soft;

        public void SetHandsetSoft(HandSoft soft)
        {
            this._soft = soft;
        }

        public abstract void Run();
    }
}