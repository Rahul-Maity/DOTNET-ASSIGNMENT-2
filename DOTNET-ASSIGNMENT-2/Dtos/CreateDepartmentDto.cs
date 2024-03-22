using System.ComponentModel.DataAnnotations;

namespace DOTNET_ASSIGNMENT_2.NewFolder
{
    public class CreateDepartmentDto
    {
        public int Dept_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Dept_Name { get; set; }
    }
}
