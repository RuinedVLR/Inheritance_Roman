using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Roman
{
    internal class Wizard : Character
    {
        Random _rand = new Random();
        ConsoleColor _color;

        void GetRandomColor()
        {
            int colorIdx = _rand.Next(1, 16);
            Console.ForegroundColor = (ConsoleColor)colorIdx;
        }

        public override void Attack(Character targetChar)
        {
            base.Attack(targetChar);
        }
        
        public override void TakeDamage(int damage)
        {
            GetRandomColor();
            base.TakeDamage(damage);
        }
    }
}
