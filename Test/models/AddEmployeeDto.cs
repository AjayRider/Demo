using System.ComponentModel.DataAnnotations;

namespace Test.models
{
    public class AddEmployeeDto
    {
      
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        public string? Salary { get; set; }
    }
}
