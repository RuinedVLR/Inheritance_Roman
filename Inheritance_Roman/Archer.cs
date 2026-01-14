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
                base.Attack(targetChar);
            }

            base.Attack(targetChar);
        }

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
        }
    }
}
