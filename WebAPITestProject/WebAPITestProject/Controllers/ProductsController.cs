using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPITestProject.Models;

namespace WebAPITestProject.Controllers
{
    public class ProductsController : ApiController
    {
        List<Product> products = new List<Product>();

        public ProductsController()
        {
            products.Add(new Product { Name = "Adidas", Description = "Ladies size 9", Id = 1, Image = "", CategoryId = 3 });
            products.Add(new Product { Name = "Samsung", Description = "Note 10", Id = 2, Image = "", CategoryId = 2 });
            products.Add(new Product { Name = "Mango", Description = "Sleeveless size M", Id = 3, Image = "", CategoryId = 1 });
        }
        // GET api/products
        public List<Product> Get()
        {
            return products;
        }

        // GET api/products/5
        public Product Get(int id)
        {
            return products.Where(p => p.Id == id).FirstOrDefault();
        }

        // POST api/products
        public void Post(Product value)
        {
            products.Add(value);
        }

        // DELETE api/products/5
        public void Delete(int id)
        {
            if (id > 0)
            {
                Product prod = products.Where(p => p.Id == id).FirstOrDefault();
                products.Remove(prod);
            }
        }
    }
}
