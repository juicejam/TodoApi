using System.Collections.Generic;
using System.Globalization;

namespace Demo
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public Product()
        {
            
        }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product{Name = "Best",Price = 9.99m},
                new Product{Name = "Aouth",Price = 29.99m},
                new Product{Name = "Cast",Price = 19.99m}
            };
        }

        public override string ToString()
        {
            return $"{Name}:{Price}";
        }
    }

    public class ProductB
    {
        public string name_b { get; set; }
        public decimal price_b { get; set; }
    }
}
