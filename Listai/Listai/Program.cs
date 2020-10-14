using System;
using System.Collections.Generic;

namespace Listai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> manoSarasas = new List<string>();
            manoSarasas.Add("Foo Bar");
            manoSarasas.Add("test");

            foreach (var item in manoSarasas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
