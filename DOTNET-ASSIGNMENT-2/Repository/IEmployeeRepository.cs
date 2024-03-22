using DOTNET_ASSIGNMENT_2.Dtos;
using DOTNET_ASSIGNMENT_2.Models;

namespace DOTNET_ASSIGNMENT_2.Repository
{
    public interface IEmployeeRepository
    {
   
        void AddEmployee(EmployeeDto employeedto);

        void EditEmployee(int id,EmployeeDto employeedto);

        void DeleteEmployee(int id);

        Employee GetEmployeeById(int id);

        List<Employee> GetAllEmployees();
    }
}
