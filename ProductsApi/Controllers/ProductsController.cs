using ProductsApi.DAL;
using ProductsApi.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace ProductsApi.Controllers
{
    public class ProductsController : ApiController
    {
        private static ProductsRepository productsRepository = new ProductsRepository();

        [HttpGet]
        public List<Product> GetAllProducts()
        {
            return productsRepository.GetProducts();
        }

        [HttpPost]
        public void CreateProduct(Product product)
        {
            productsRepository.Add(product);
        }

        [HttpGet]
        public Product GetProductById(int id)
        {
            return productsRepository.GetById(id);
        }

        [HttpDelete]
        public void DeleteProduct(int id)
        {
            productsRepository.Delete(id);
        }

        [HttpPost]
        public void UpdateProduct(Product product)
        {
            productsRepository.Update(product);
        }

    }
}
