using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EComm.ProductService.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
       
        public int Price { get; set; }
        public string Description { get; set; }

    }
}
