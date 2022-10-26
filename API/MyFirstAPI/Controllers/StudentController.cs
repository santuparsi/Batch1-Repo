using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet,Route("GetAllStudents")]
        public IActionResult GetAll()
        {
            string[] s = { "Rohan", "Shejal", "Priam" };
            return StatusCode(200,s);
        }
        [HttpGet,Route("GetStudent/{id}")]
        public IActionResult Get(int id)
        {
            return StatusCode(200, "Rajan");
        }
        [HttpPost,Route("AddStudent")]
        public IActionResult Add(object student)
        {
            return StatusCode(200, "Student Added");
        }
        [HttpPut,Route("EditStudent")]
        public IActionResult Edit(object student)
        {
            return StatusCode(200, "Student Edited");
        }
        [HttpDelete,Route("DeleteStudent/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return StatusCode(200, "Student Deleted");
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
    }
}
