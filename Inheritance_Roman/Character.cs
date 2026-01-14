using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Roman
{
    internal class Character
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }

        public virtual void Attack(Character targetChar)
        {
            Console.WriteLine($"Target Character: {targetChar}");
            targetChar.TakeDamage(AttackPower);
        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }
    }
}
