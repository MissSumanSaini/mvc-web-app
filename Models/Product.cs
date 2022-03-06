using System;
using System.Collections.Generic;

#nullable disable

namespace mvc_web_app.Models
{
    public partial class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public string Imagerl { get; set; }
    }
}
