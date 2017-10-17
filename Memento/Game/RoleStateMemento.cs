using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Game
{
    internal class RoleStateMemento
    {
        public int Vit { get; private set; }

        public int Attack { get; private set; }

        public int Defense { get; private set; }

        public RoleStateMemento(int vit, int attack, int defense)
        {
            this.Vit = vit;
            this.Attack = attack;
            this.Defense = defense;
        }
    }
}