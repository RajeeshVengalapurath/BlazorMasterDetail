using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Product
    {
        static List<Product> _products;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        static Product()
        {
            _products = new List<Product> { 
                new Product { Id=1, Name="Prodct1", Rate=100},
                new Product { Id=2, Name="Prodct2", Rate=200},
                new Product { Id=3, Name="Prodct3", Rate=300}
            };
        }
        public static List<Product> GetAllProducts()
        {
            return _products;
        }
        public static decimal GetRate(int productId)
        {
            return _products.FirstOrDefault(e => e.Id == productId).Rate;
        }
    }
}
