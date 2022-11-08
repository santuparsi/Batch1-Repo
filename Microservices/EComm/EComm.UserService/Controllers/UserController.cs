using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EComm.UserService.Models;
namespace EComm.UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet,Route("GetUsers")]
        public IActionResult GetUser()
        {
            return StatusCode(200, "Hai Users");
        }
        [HttpPost,Route("SingIn")]
        public IActionResult Validate(User user)
        {
            return StatusCode(200);
        }
        [HttpPost,Route("SignUp")]
        public IActionResult SignUp(User user)
        {
            return StatusCode(200);
        }
    }
}
