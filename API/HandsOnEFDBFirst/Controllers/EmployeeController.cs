using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnEFDBFirst.Repositories;
using HandsOnEFDBFirst.Entities;
namespace HandsOnEFDBFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository employeeRepository;
        public EmployeeController()
        {
            employeeRepository = new EmployeeRepository();
        }

        //Endpoints
        [HttpGet,Route("GetEmployees")]
        public IActionResult GetAll()
        {
            try
            {
                return StatusCode(200, employeeRepository.GetEmployees());
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet, Route("GetEmployee/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return StatusCode(200, employeeRepository.GetEmployee(id));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost,Route("AddEmployee")]
        public IActionResult Add(Employee employee)
        {
            try
            {
                employeeRepository.AddEmployee(employee);
                return StatusCode(200, employee);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
    }
}
