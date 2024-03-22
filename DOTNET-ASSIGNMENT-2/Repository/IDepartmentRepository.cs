using DOTNET_ASSIGNMENT_2.Models;
using DOTNET_ASSIGNMENT_2.NewFolder;

namespace DOTNET_ASSIGNMENT_2.Repository
{
    public interface IDepartmentRepository
    {
        void AddDepartment(CreateDepartmentDto departmentDto);
        void EditDepartment(int id, string name);
        void DeleteDepartment(int id);
        Department GetDepartment(int id);
        IEnumerable<Department> GetAll();
    }
}
