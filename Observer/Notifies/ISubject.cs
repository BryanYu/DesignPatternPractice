using Observer.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Notifies
{
    internal interface ISubject
    {
        void Attach(AbstractObserver observer);

        void Detach(AbstractObserver observer);

        void Notify();

        string Subjectstate
        {
            get; set;
        }
    }
}