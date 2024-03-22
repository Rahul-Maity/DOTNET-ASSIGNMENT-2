using DOTNET_ASSIGNMENT_2.Models;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace DOTNET_ASSIGNMENT_2.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Range(21, 100)]
        public int Age { get; set; }
        public int Dept_Id { get; set; }

        [Required]
        public int Salary { get; set; }
    }

    
}
