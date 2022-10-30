using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMooiste.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; }
        //public Category Category { get; set; }
        //public int CategoryId { get; set; }
        //public bool Featured { get; set; } = false;
    }
}
