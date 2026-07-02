using Microsoft.AspNetCore.Mvc;
using EmployeeAPI.Models;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public Employee GetEmployee()
        {
            return new Employee
            {
                Id = 1,
                Name = "Abhi",
                Department = "IT"
            };
        }
    }
}