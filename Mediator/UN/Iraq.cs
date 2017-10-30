using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.UN
{
    internal class Irag : Country
    {
        public Irag(UnitedNations mediator) : base(mediator)
        {
        }

        public void Declare(string message)
        {
            this._meditor.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine($"Iraq Get Message{message}");
        }
    }
}