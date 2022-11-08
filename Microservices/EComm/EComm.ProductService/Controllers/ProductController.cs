using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EComm.ProductService.Models;
namespace EComm.ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet, Route("GetProducts")]
        public IActionResult GetProducts()
        {
            return StatusCode(200,"Get All Products");
        }
        [HttpGet, Route("GetProduct/{id}")]
        public IActionResult GetProducts(int id)
        {
            return StatusCode(200,"GetProductById");
        }
        [HttpPost, Route("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            return StatusCode(200);
        }
        [HttpPut, Route("EditProduct")]
        public IActionResult EditProduct(Product product)
        {
            return StatusCode(200);
        }
        [HttpGet, Route("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return StatusCode(200);
        }

    }
}
