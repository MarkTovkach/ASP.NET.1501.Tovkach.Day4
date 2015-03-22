using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Syntax;
using Ninject.Parameters;
using ShopModel.Discounter;

namespace ShopModel
{
    public static class Program
    {
        public static void Main()
        {
            IKernel kernel = new StandardKernel(new ConfigModule());

            var cart = new ShoppingCart(kernel.Get<INumerate>())
            {
                Products = new List<Product>()
                {
                    new Product {Name = "Product 1", Category = "C1", Description = "no", ProductID = 1, Price = 100},
                    new Product {Name = "Product 2", Category = "C2", Description = "no", ProductID = 2, Price = 200}
                }
            };

            Console.WriteLine("Total price = {0}$", kernel.Get<IDiscount>().ApplyDiscount(cart.CalculateProductTotal(),10));
        }
    }
}