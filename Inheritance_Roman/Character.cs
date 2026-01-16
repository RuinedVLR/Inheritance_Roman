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
        public int AttackPowerMin { get; set; }
        public int AttackPowerMax { get; set; }
        public int Speed { get; set; }

        public int turnsToAct = 0;

        static Random _rand = new Random();

        public virtual void Attack(Character targetChar)
        {
            targetChar.TakeDamage(_rand.Next(AttackPowerMin, AttackPowerMax));
            turnsToAct = 0;
        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public Character(int health, string name, int attackPowerMin, int attackPowerMax, int speed)
        {
            Health = health;
            Name = name;
            AttackPowerMin = attackPowerMin;
            AttackPowerMax = attackPowerMax;
            Speed = speed;
        }
    }
}
