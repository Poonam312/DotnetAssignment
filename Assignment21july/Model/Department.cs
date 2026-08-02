using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Department
    {
        [Required]
        public string DepartmentName { get; set; }

        [Required]
        public string DepartmentHead { get; set; }

        [Required]
        [Phone]
        public string HeadContactNumber { get; set; }

        [Required]
        [EmailAddress]
        public string HeadEmail { get; set; }
    }
}