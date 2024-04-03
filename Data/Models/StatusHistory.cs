using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class StatusHistory
    {
        [Key]
        public int StatusHistoryId { get; set; }
        public int CarId { get; set; }
        public int StatusId { get; set; }
        public DateTime StatusDate { get; set; }
        public string? ChangedBy { get; set; }
    }
}
