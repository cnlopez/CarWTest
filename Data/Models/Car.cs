using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public int Year { get; set; }
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string? Submodel { get; set; }
    }
}
