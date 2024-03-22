using DOTNET_ASSIGNMENT_2.Dtos;
using DOTNET_ASSIGNMENT_2.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_ASSIGNMENT_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = _employeeRepository.GetAllEmployees();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id) {
            var employees=_employeeRepository.GetEmployeeById(id);
            if (employees != null)
            {
                return Ok(employees);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult AddEmployee([FromBody] EmployeeDto employeeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _employeeRepository.AddEmployee(employeeDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult EditEmployee(int id, [FromBody] EmployeeDto employeeDto)
        {
            _employeeRepository.EditEmployee(id,employeeDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return Ok();
        }


    }
}
