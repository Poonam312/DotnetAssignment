using System.ComponentModel.DataAnnotations;

namespace AutomobileManagementSystem.Models
{
    public class Manufacturer
    {
        [Required]
        public string ManufacturerName { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        [Phone]
        public string ContactNumber { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}