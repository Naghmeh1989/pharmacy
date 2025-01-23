namespace PharmacyAPI.Models.DTOs
{
    public class PriceHistoryDto
    {
        public int Id { get; set; }

        public int OldPrice { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; } = null!;

        public DateTime ModifiedDate { get; set; }

        public string ModifiedBy { get; set; } = null!;

        public int ProductId { get; set; }
    }
}
