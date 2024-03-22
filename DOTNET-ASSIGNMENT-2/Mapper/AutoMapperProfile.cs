using AutoMapper;
using DOTNET_ASSIGNMENT_2.Dtos;
using DOTNET_ASSIGNMENT_2.Models;
using DOTNET_ASSIGNMENT_2.NewFolder;

namespace DOTNET_ASSIGNMENT_2.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() { 
            CreateMap<Employee,EmployeeDto>().ReverseMap();
            CreateMap<Department, CreateDepartmentDto>().ReverseMap();
        }
    }
}
