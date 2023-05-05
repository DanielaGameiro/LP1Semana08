using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SpyUnit : XPUnit
    {
        public override float Cost { get; set; } 
        public int Movement;
        public override int Health { get; set; }

        public SpyUnit(): base(8,2)
        {
            Cost = 12.5f;
        }

        public void GetSecretInfo(Unit unit)
        {
            if (unit is SpyUnit)
                XP += 3;
            else if (unit is MilitaryUnit)
                XP += 2;
            else
                XP++;
        }
    }
}