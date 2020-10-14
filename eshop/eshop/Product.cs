using System;
using System.Collections.Generic;
using System.Text;

namespace eshop
{
    
    public sealed class Product : BaseProduct, IAdultProduct, IKidProduct
    {
        
        public Supplyer Supplyer { get; set; }
        public bool IsAdultProduct { get; set; }
        public bool IsKidProduct { get; set; }

        bool IAdultProduct.CanIBuyAdultProduct { get; set; }

        public bool CanIBuyAdultProduct(int age)
        {
            return age >= 18;
           
        }
    }
}
