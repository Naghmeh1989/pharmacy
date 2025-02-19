namespace PharmacyAPI.Models.DTOs
{
    public class UpdateTransactionStatusDto
    {
        public string Status { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; } = null!;

        public DateTime? ModifiedDate { get; set; }

        public string? ModifiedBy { get; set; }
    }
}
