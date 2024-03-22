using DOTNET_ASSIGNMENT_2.Data;
using DOTNET_ASSIGNMENT_2.Models;
using DOTNET_ASSIGNMENT_2.NewFolder;


namespace DOTNET_ASSIGNMENT_2.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;
        public DepartmentRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddDepartment(CreateDepartmentDto departmentDto)
        {
            var department=new Department{
                Dept_Id=departmentDto.Dept_Id,
                Dept_Name=departmentDto.Dept_Name

            };
            _context.Departments.Add(department);
            _context.SaveChangesAsync();
        }

        public void DeleteDepartment(int id)
        {
            var department = _context.Departments.FirstOrDefault(i => i.Dept_Id == id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                _context.SaveChangesAsync();
            }
        }

        public void EditDepartment(int id, string name)
        {
            var existingDepartment = _context.Departments.FirstOrDefault(i => i.Dept_Id == id);
            if (existingDepartment != null)
            {
                existingDepartment.Dept_Name = name;
                _context.SaveChangesAsync();
;
            }
        }

        public IEnumerable<Department> GetAll()
        {
            return _context.Departments.ToList() ;
        }

        public Department GetDepartment(int id)
        {
            return _context.Departments.FirstOrDefault(i => i.Dept_Id == id);
        }
    }
}
