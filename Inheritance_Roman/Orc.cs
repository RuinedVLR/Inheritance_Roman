using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Roman
{
    internal class Orc : Character
    {
        int _healPerk = 5;

        public override void Attack(Character targetChar)
        {
            Console.WriteLine($"{Name} attacks!");
            Console.WriteLine();
            Health += _healPerk;
            base.Attack(targetChar);
        }
        
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            Console.WriteLine($"{Name} takes {damage} damage but heals {_healPerk} health!");
            Console.WriteLine();
        }

        public Orc(int health, string name, int atkMin, int atkMax, int speed) : base(health, name, atkMin, atkMax, speed)
        {

        }
    }
}
