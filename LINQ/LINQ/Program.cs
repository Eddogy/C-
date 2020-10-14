using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> myStrings = new List<string>();
            myStrings.Add("Edgaras");
            myStrings.Add("Jonas");
            myStrings.Add("Paulius");
            myStrings.Add("Jurgis");
            myStrings.Add("Konoras");

            // string manoVardas = myStrings.Where(x => x == "Edgaras").FirstOrDefault();
            // Console.WriteLine(manoVardas);
            IList<string> manoVardai = myStrings.Where(x => x == "Edgaras").ToList();
            manoVardai.Add("Edgaras");
            Console.WriteLine(manoVardai.Count);
        }

    }
}
