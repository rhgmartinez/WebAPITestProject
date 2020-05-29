using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPITestProject.Models;

namespace WebAPITestProject.Controllers
{
    public class CategoryController : ApiController
    {
        List<Category> categories = new List<Category>();
        public CategoryController()
        {
            categories.Add(new Category { Name = "Clothes", Id = 1 });
            categories.Add(new Category { Name = "Gadgets", Id = 2 });
            categories.Add(new Category { Name = "Shoes", Id = 3 });
        }
        // GET api/category
        public List<Category> Get()
        {
            return categories;
        }

        // GET api/category/5
        public Category Get(int id)
        {
            return categories.Where(c => c.Id == id).FirstOrDefault();
        }

        // POST api/category
        public void Post(Category value)
        {
            categories.Add(value);
        }

        // DELETE api/category/5
        public void Delete(int id)
        {
            if (id > 0)
            {
                Category cat = categories.Where(c => c.Id == id).FirstOrDefault();
                categories.Remove(cat); 
            }
        }
    }
}
