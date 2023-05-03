using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; set; }

        public override int Health => base.Health + XP;

        public override float Cost => AttackPower + XP;

        public void Attack(Unit unit)
        {
            unit.Health -= AttackPower;
            XP++;
        }

        // Construtor da MilitaryUnit que passa para a classe base os seus parâmetros
        public MilitaryUnit(int movement, int health, int attackPower)
            : base(movement, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }
    }
}