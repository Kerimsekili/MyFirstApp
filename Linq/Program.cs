using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1,CategoryName = "Computer"},
                new Category{CategoryId = 2,CategoryName = "Phone"}
            };

            List<Product> products = new List<Product>
            {
                new Product {ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32GB Ram", UnitPrice = 10000, UnitInStock = 5},
                new Product {ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "64GB Ram", UnitPrice = 8000, UnitInStock = 15},
                new Product {ProductId = 3, CategoryId = 1, ProductName = "Huawei Laptop", QuantityPerUnit = "16GB Ram", UnitPrice = 6000, UnitInStock = 10},
                new Product {ProductId = 4, CategoryId = 2, ProductName = "Apple Phone", QuantityPerUnit = "4GB Ram", UnitPrice = 5000, UnitInStock = 20},
                new Product {ProductId = 5, CategoryId = 2, ProductName = "Samsung Phone", QuantityPerUnit = "2GB Ram", UnitPrice = 7500, UnitInStock = 35}

            };
            //AnyTest(products);
            //lambda
            //FindTest(products);

            //FindAllTest(products);
            //AscDscTest(products);

            //MultiTest(products);

            //Test(products);
            var result = from p in products
                         join c in categories on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var productDto in result)
            {
                Console.WriteLine("{0}-----{1}", productDto.ProductName, productDto.CategoryName);
            }
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Linq----------------");
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 10);


            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }
        }

        private static void MultiTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var VARIABLE in result)
            {
                Console.WriteLine(VARIABLE.ProductName);
            }
        }

        private static void AscDscTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);
        }
    }
}

class ProductDto
{
    public int ProductId { get; set; }
    public string CategoryName { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
}

class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitInStock { get; set; }

}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}

