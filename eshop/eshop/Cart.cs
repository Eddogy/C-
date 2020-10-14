using System;
using System.Collections.Generic;
using System.Text;

namespace eshop
{
    public class Cart
    {

        public Cart(bool tobepaidByCash)
        {
            IsPaidByCash = tobepaidByCash;
            Id = Guid.NewGuid();
            Products = new List<Product>();
            Services = new List<Service>();
            
    }
        public Guid Id { get; set; }
        public IList <Product> Products { get; set; }
        public IList <Service> Services { get; set; }
        public int AmmountToPay { get; set; }
        public bool IsPaidByCash { get; set; }
        public bool IsInvoiceSent { get; set; }

        public void AddProductToCart(Product product)
        {
            if (product.IsAdultProduct)
            {
                Console.WriteLine("Koks tavo amzius?");
                int input = int.Parse(Console.ReadLine());
                if (product.CanIBuyAdultProduct(input))
                {
                    Products.Add(product);
                }

            }
            else
            {
                Products.Add(product);
            }
        }


    }
}
