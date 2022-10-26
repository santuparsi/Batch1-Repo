using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEFCodeFirst.Entities;
using HandsOnAPIUsingEFCodeFirst.Services;
namespace HandsOnAPIUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService service;
        public ProductController()
        {
            this.service = new ProductService();
        }
        [Route("GetAllProducts")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> products = service.GetAll();
            return StatusCode(200,products);
        }
        [HttpGet]
        [Route("Get/{id}")]
        public IActionResult Get(int id)
        {
            Product product = service.Get(id);
            return StatusCode(200,product);
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Product product)
        {
            service.Add(product);
            return StatusCode(200,product);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            service.Delete(id);
            return StatusCode(200,"Product with "+id+" Deleted");
        }
        [HttpPut]
        [Route("Edit")]
        public IActionResult Edit(Product product)
        {
            service.Edit(product);
            return StatusCode(200, product);
        }

    }
}
