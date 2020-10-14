using System;

namespace Palukanos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite norima pradeti suma!");
            double input = double.Parse(Console.ReadLine());
            int metai = 2;
            double palukanos = 1.02;
            double indelis = input;
            for (int i = 1; i <= metai; i++)
            {
                indelis = indelis * palukanos;
                Console.WriteLine($"Po {i} metu jus turesit {indelis}");
            }

        }
    }
}
