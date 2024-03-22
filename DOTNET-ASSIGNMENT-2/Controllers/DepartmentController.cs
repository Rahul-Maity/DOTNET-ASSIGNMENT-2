using DOTNET_ASSIGNMENT_2.Models;
using DOTNET_ASSIGNMENT_2.NewFolder;
using DOTNET_ASSIGNMENT_2.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; 

namespace DOTNET_ASSIGNMENT_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        [HttpGet]
        public IActionResult GetAllDept()
        {
            var departments=_departmentRepository.GetAll();
            return Ok(departments);
        }
        [HttpGet("{id}")]
        public IActionResult GetDepartment(int id)
        {
            var department = _departmentRepository.GetDepartment(id);
            if(department != null)
            {
                return Ok(department);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddDepartment([FromBody]CreateDepartmentDto departmentDTO)
        {
          _departmentRepository.AddDepartment(departmentDTO);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult EditDepartment(int id, string name)
        {
            _departmentRepository.EditDepartment(id, name);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            _departmentRepository.DeleteDepartment(id);
            return Ok();
        }
    }
}
