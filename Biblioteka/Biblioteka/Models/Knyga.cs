using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka.Models
{
    public class Knyga
    {
        public Knyga()
        {
            Zanrai = new List<Zanras>();
            Tipai = new List<Tipas>();
            Autoriai = new List<Autorius>();
            
        }

        public List <Zanras> Zanrai { get; set; }
        public List <Tipas> Tipai { get; set; }
        public List <Autorius> Autoriai { get; set; }
        public UzimtumasKnygos UzimtumasKnygos { get; set; }

    }
}
