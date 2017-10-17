using Memento.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GameRole solider = new GameRole();
            solider.GetInitState();
            solider.StateDisplay();

            RoleStateCaretaker stateAdmin = new RoleStateCaretaker();
            stateAdmin.Memento = solider.SaveState();

            solider.Fight();
            solider.StateDisplay();

            solider.RecoveryState(stateAdmin.Memento);

            solider.StateDisplay();
            Console.Read();
        }
    }
}