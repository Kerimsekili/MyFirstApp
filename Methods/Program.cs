using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 10;
            product1.Explanation = "Amasya Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Explanation = "Diyerbakır Karpuzu";

            Product[] products = new Product[] {product1,product2 };

            //typesafe
            foreach (Product product in products)
            {
              Console.WriteLine(product.Name);
              Console.WriteLine(product.Price);
              Console.WriteLine(product.Explanation);
              Console.WriteLine("--------------------");

            }

            Console.WriteLine("--------------------");

            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);
            
        }
    }
}
