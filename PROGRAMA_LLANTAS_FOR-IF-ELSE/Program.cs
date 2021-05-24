using System;

namespace FOR_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; Console.BackgroundColor = ConsoleColor.Black;
            int fStone = 0, kHo = 0, gYear = 0, x;
            int medidaRinfStone, rinMayorfStone = 0, medidaRinkHo, rinMayorkHo = 0, medidaRinGyear, rinMayorGyear = 0;
            string marcaNeu;
            for (x = 1; x <= 6; x++)
            {
                Console.WriteLine("Ingrese la marca del neumatico (ingresar en mayusculas)");
                marcaNeu = Console.ReadLine();
                if (marcaNeu == "FIRESTONE")
                {
                    fStone++;
                    Console.WriteLine("Ingrese ingrese el número de rin");
                    medidaRinfStone = int.Parse(Console.ReadLine());
                    if (medidaRinfStone > 15)
                    {
                        rinMayorfStone++;
                    }
                }
                else if (marcaNeu == "KUMHO")
                {
                    kHo++;
                    Console.WriteLine("Ingrese ingrese el número de rin");
                    medidaRinkHo = int.Parse(Console.ReadLine());
                    if (medidaRinkHo > 15)
                    {
                        rinMayorkHo++;
                    }
                }
                else if (marcaNeu == "GOODYEAR")
                {
                    gYear++;
                    Console.WriteLine("Ingrese ingrese el número de rin");
                    medidaRinGyear = int.Parse(Console.ReadLine());
                    if (medidaRinGyear > 15)
                    {
                        rinMayorGyear++;
                    }
                }

            }
            Console.WriteLine($"Hemos encontrado lo siguiente para la marca FIRESTONE: {fStone} unidades en stock, de las cuales {rinMayorfStone} son rin mayor a 15'' ");            
            Console.WriteLine($"Hemos encontrado lo siguiente para la marca KUMHO: {kHo} unidades en stock, de las cuales {rinMayorkHo} son rin mayor a 15'' ");
            Console.WriteLine($"Hemos encontrado lo siguiente para la marca GOODYEAR: {gYear} unidades en stock, de las cuales {rinMayorGyear} son rin mayor a 15'' ");
            
            Console.WriteLine("\n"); Console.WriteLine("-->Fin del programa"); Console.ReadKey();
        }
    }
}