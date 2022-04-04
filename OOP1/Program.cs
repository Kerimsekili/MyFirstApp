using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Desk";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product{Id = 2,CategoryId = 5,UnitInStock = 34,ProductName = "Pencil",UnitPrice = 25};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);

        }
    }
}
