using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.UN
{
    internal class UnitedNationSecurityCouncil : UnitedNations
    {
        public USA Colleague1 { get; set; }

        public Irag Colleague2 { get; set; }

        public override void Declare(string message, Country colleague)
        {
            if (colleague == Colleague1)
            {
                Colleague2.GetMessage(message);
            }
            else
            {
                Colleague1.GetMessage(message);
            }
        }
    }
}