using AutoMapper;
using DOTNET_ASSIGNMENT_2.Data;
using DOTNET_ASSIGNMENT_2.Dtos;
using DOTNET_ASSIGNMENT_2.Models;


namespace DOTNET_ASSIGNMENT_2.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
           
        }
        public void AddEmployee(EmployeeDto employeedto)
        {
           var Employee=new Employee
           {
               Id = employeedto.Id,
               Name = employeedto.Name,
               Age = employeedto.Age,
               Dept_Id=employeedto.Dept_Id,
               Salary=employeedto.Salary

           };
            _context.Employees.Add(Employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var employee=_context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }

        }

        public void EditEmployee(int id,EmployeeDto employeedto)
        {
            var employee= _context.Employees.FirstOrDefault(i=>i.Id == id);
            if(employee != null)
            {
                employee.Name=employeedto.Name;
                employee.Salary=employeedto.Salary;
                employee.Age=employeedto.Age;
                employee.Dept_Id = employeedto.Dept_Id;
                _context.SaveChanges();
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
           return _context.Employees.FirstOrDefault(i => i.Id == id);
          


        }
    }
}
