using System;
using System.Collections.Generic;
using System.Text;

namespace Juodrastis
{
    public abstract class Masina
    {
        public string Spalva { get; set; }
        public string KuroTipas { get; set; }

        public abstract int KiekRatu();


            
    }
}
