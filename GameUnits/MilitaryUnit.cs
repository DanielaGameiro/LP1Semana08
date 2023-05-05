using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : XPUnit
    {
        public int AttackPower { get; }

        public override int Health => base.Health + XP;

        public override float Cost => AttackPower + XP;

        public void Attack(Unit unit)
        {
            unit.Health--;
            XP++;
        }

        // Construtor da MilitaryUnit que passa para a classe base os seus parâmetros
        public MilitaryUnit(int movement, int health, int attackPower)
            : base(movement, health)
        {
            AttackPower = attackPower;
        }

        public override string ToString()
        {
            return $"{base.ToString()} AP={AttackPower}";
        }
    }
}