using ProductsApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductsApi.DAL
{
    public class ProductsRepository
    {
        private List<Product> Products { get; set; }

        public List<Product> GetProducts()
        {
            return Products;
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public void Delete(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);

            if (product != null)
                Products.Remove(product);
        }

        public void Update(Product product)
        {
            var productToUpdate = Products.FirstOrDefault(p => p.Id == product.Id);

            if (productToUpdate != null)
                productToUpdate = product;
        }

        public Product GetById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }

        public ProductsRepository()
        {
            Products = new List<Product>()
            {
                new Product() { Id = 1, Category = "Food", Name = "Onion", Price = 2 },
                new Product() { Id = 2, Category = "Electronics", Name = "Keyboard", Price = 23 },
                new Product() { Id = 3, Category = "Electronics", Name = "Mouse", Price = 10 }
            };
        }
    }
}