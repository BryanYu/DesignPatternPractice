using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Game
{
    internal class GameRole
    {
        public int Vit { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public void StateDisplay()
        {
            Console.WriteLine("角色當前狀態");
            Console.WriteLine($"體力：{this.Vit}");
            Console.WriteLine($"攻擊力：{this.Attack}");
            Console.WriteLine($"防禦力：{this.Defense}");
        }

        public void GetInitState()
        {
            this.Vit = 100;
            this.Attack = 100;
            this.Defense = 100;
        }

        public void Fight()
        {
            this.Vit = 0;
            this.Attack = 0;
            this.Defense = 0;
        }
    }
}