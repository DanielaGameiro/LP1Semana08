using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    // É  abstract porque num jogo 4x não é utilizado uma Unit só base, mas sim 
    // as Units derivadas dessa base. Não podemos criar mais Units,
    // e sim, apenas mais MilitaryUnits e SettlerUnits.
    public abstract class Unit
    {
        private readonly int movement;
        public virtual int Health { get; set; }

        public abstract float Cost { get; }

        // Construtor da Unit 
        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            Console.WriteLine($"Moveu {movement} unidades.");
        }
    }
}