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
        public List<Product> GetProducts()
        {
            return productsRepository.GetProducts();
        }

        [HttpPost]
        public void Create(Product product)
        {
            productsRepository.Add(product);
        }

        [HttpGet]
        public Product GetById(int id)
        {
            return productsRepository.GetById(id);
        }
    }
}
