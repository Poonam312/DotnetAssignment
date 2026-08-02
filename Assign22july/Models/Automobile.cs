using System.ComponentModel.DataAnnotations;

namespace AutomobileManagementSystem.Models
{
    public class Automobile
    {
        [Required(ErrorMessage = "Vehicle ID is required")]
        public int VehicleId { get; set; }

        [Required]
        [StringLength(50)]
        public string VehicleName { get; set; }

        [Required]
        [StringLength(30)]
        public string Brand { get; set; }

        [Required]
        [Range(2000, 2035)]
        public int ModelYear { get; set; }

        [Required]
        [Range(10000, 10000000)]
        public decimal Price { get; set; }

        [Required]
        [RegularExpression("Petrol|Diesel|Electric|CNG",
            ErrorMessage = "Fuel Type must be Petrol, Diesel, Electric or CNG")]
        public string FuelType { get; set; }
    }
}