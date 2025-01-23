namespace PharmacyAPI.Models.DTOs
{
    public class PaymentDto
    {
        public int Id { get; set; }

        public string Method { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; } = null!;

        public DateTime? ModifiedDate { get; set; }

        public string? ModifiedBy { get; set; }

        public decimal PaymentAmount { get; set; }

        public int PaymentStatusId { get; set; }

        public int TransactionId { get; set; }
    }
}
