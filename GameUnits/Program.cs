using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar e inicializar
            Unit[] units = new Unit[] {
                new MilitaryUnit(4, 100, 50),
                new SettlerUnit(1, 20)};

            foreach (Unit unit in units)
            {
                // Imprimir o nome do Unit

                // if (unit is MilitaryUnit)
                //     Console.WriteLine("Military");
                // else if (unit is SettlerUnit)
                //     Console.WriteLine("Settler");

                Console.WriteLine(unit.GetType().Name);

                unit.Move();
                Console.WriteLine($"Health = {unit.Health}");
                Console.WriteLine($"Cost = {unit.Cost}");
                Console.WriteLine();
            }
        }
    }
}
