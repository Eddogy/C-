using System;
using System.Collections.Generic;
using System.Text;

namespace Juodrastis
{
     public class Studentas
    {

        public Studentas()
        {

        }


        public Studentas(string name)
        {
            Vardas = name;
        }

        public Studentas(string name, string surname)
        {
            Vardas = name;
            Pavarde = surname;
        }


        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string PilnasVardas
        {
            get { return $"{Vardas} {Pavarde}"; }
        }
        
        public void printName()
        {
            Console.WriteLine(Vardas);
        }
       
    }

    
}
