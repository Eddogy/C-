using System;
using System.Collections.Generic;
using System.Text;

namespace eshop
{
    public abstract class BaseProduct
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public Status Status { get; set; }
        public string Name { get; set; }


    }
}
