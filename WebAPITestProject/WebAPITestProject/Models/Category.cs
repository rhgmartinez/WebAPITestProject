using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPITestProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category()
        {
            this.Id = 0;
            this.Name = "";
        }
    }
}