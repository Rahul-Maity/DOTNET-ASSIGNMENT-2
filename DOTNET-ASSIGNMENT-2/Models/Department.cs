using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace DOTNET_ASSIGNMENT_2.Models
{
    public class Department
    {
        [Key]
        public int Dept_Id { get; set; } 
        public string Dept_Name { get; set; }
        
    }
    public class DepartmentValidator : AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(x=>x.Dept_Name).Length(0,50);
        }
    }
}
