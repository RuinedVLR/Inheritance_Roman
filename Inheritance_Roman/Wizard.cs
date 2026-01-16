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

        ConsoleColor GetRandomColor()
        {
            int colorIdx = _rand.Next(1, 16);
            return (ConsoleColor)colorIdx;
        }

        public override void Attack(Character targetChar)
        {
            Console.WriteLine($"{Name} casts a spell!");
            Console.WriteLine();
            base.Attack(targetChar);
        }
        
        public override void TakeDamage(int damage)
        {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = GetRandomColor();

            base.TakeDamage(damage);
            Console.WriteLine($"{Name} takes {damage} damage and changes text color!");
            Console.WriteLine();
        }

        public Wizard(int health, string name, int atkMin, int atkMax, int speed) : base(health, name, atkMin, atkMax, speed)
        {

        }
    }
}
