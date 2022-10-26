using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingModels.Services;
using HandsOnAPIUsingModels.Models;
namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service;
        public ProductController()
        {
            _service = new ProductService();
        }
        //define action-methods
        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProducts()
        {
            try
            {
                List<Product> products = _service.GetProducts();
                return Ok(products);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetProductById/{productId}")]
        public IActionResult GetProuct(int productId)
        {
            try
            {
                Product product = _service.GetProduct(productId);
                if (product != null)
                    return Ok(product);
                else
                    return NotFound("Invalid Id");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            try
            {
                _service.AddProduct(product);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
        [HttpPut]
        [Route("EditProduct")]
        public IActionResult EditProduct(Product product)
        {
            try
            {
                _service.UpdateProduct(product);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("Delete/{productId}")]
        public IActionResult DeleteProduct(int productId)
        {
            try
            {
                _service.DeleteProduct(productId);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}
