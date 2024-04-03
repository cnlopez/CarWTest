using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string ZipCode { get; set; } = string.Empty;
    }
}
