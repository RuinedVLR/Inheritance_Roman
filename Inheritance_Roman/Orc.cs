using System;
using System.Collections.Generic;
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
            Health += _healPerk;
            base.Attack(targetChar);
        }
        
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(AttackPower);
        }
    }
}
