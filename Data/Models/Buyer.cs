using System.ComponentModel.DataAnnotations;


namespace Data.Models
{
    public class Buyer
    {
        [Key]
        public int BuyerId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
