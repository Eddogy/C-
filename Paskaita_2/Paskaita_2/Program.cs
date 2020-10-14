using System;

namespace Paskaita_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savaites diena (1-7)");
            WeekDays day = (WeekDays)int.Parse(Console.ReadLine());
            Console.WriteLine(day);

        }
        enum WeekDays
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
       
    }
}
