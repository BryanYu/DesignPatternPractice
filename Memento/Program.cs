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

            GameRole backup = new GameRole();
            backup.Vit = solider.Vit;
            backup.Attack = solider.Attack;
            backup.Defense = solider.Defense;

            solider.Fight();
            solider.StateDisplay();

            solider.Vit = backup.Vit;
            solider.Attack = backup.Attack;
            solider.Defense = backup.Defense;

            solider.StateDisplay();
            Console.Read();
        }
    }
}