namespace Business.ModelsDTO
{
    public class CarInfoDTO
    {
        public int Year { get; set; }
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string? SubModel { get; set; }
        public string BuyerName { get; set; } = string.Empty;
        public float QuoteAmount { get; set; }
        public string StatusName { get; set; } = string.Empty;
        public DateTime StatusDate { get; set; }
    }
}
