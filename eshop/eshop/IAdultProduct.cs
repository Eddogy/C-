using System;
using System.Collections.Generic;
using System.Text;

namespace eshop
{
    public interface IAdultProduct
    {
        bool IsAdultProduct { get; set; }

        public bool CanIBuyAdultProduct { get; set; }
     
    }
}
