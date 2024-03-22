using FluentValidation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOTNET_ASSIGNMENT_2.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public Department Department { get; set; }
        public int Salary { get; set; }
    }
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator() {
            RuleFor(x => x.Name).Length(0, 30);
            RuleFor(x=>x.Age).InclusiveBetween(21, 100);
        }
    }
}
