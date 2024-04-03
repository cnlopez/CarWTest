using System.ComponentModel.DataAnnotations;
namespace Data.Models
{
    public class Quote
    {
        [Key]
        public int QuoteId { get; set; }
        public int CarId { get; set; }
        public int BuyerId { get; set; }
        public decimal Amount { get; set; }
        public bool IsCurrent { get; set; }
    }
}
