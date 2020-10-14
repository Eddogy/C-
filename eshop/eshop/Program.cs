using System;

namespace eshop
{
    class Program
    {
        static void Main(string[] args)
        {
            IAdultProduct adultDVD = new Product() { Name = "kazanova", Price=1001 };
            adultDVD.IsAdultProduct = true;
            

            Console.WriteLine("kortele ar grynais?");
            bool IsByCash = Console.ReadLine() == "grynais";
            Cart krepselis = new Cart(IsByCash);

            krepselis.AddProductToCart(new Product() { Name= "sampunas" , Price=10});
           krepselis.AddProductToCart(adultDVD as Product);
           
            foreach (var item in krepselis.Products)
            {
                krepselis.AmmountToPay += item.Price;
 
            }

            Console.WriteLine("Tau reikia sumoketi " + krepselis.AmmountToPay);
            Product naujas = new Product();
            n



        }
    }
}
