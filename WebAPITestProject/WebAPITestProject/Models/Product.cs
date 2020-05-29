using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPITestProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Product(){
            this.Id = 0;
            this.CategoryId = 0;
            this.Name = "";
            this.Description = "";
            this.Image = "";
        }
    }
}