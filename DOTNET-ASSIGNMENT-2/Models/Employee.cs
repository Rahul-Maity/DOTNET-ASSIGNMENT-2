using FluentValidation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOTNET_ASSIGNMENT_2.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Range(21, 100)]
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public Department Department { get; set; }

        [Required]
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
