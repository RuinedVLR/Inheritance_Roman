using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Roman
{
    internal class Archer : Character
    {
        Random _rand = new Random();

        public override void Attack(Character targetChar)
        {
            if (_rand.Next(0, 5) == 0)
            {
                Console.WriteLine($"{Name} performs a double hit!");
                Console.WriteLine();
                base.Attack(targetChar);
            }

            Console.WriteLine($"{Name} shoots an arrow!");
            Console.WriteLine();
            base.Attack(targetChar);
        }

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            Console.WriteLine($"{Name} takes {damage} damage!");
            Console.WriteLine();
        }

        public Archer(int health, string name, int atkMin, int atkMax, int speed) : base(health, name, atkMin, atkMax, speed)
        {

        }
    }
}
