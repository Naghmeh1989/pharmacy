namespace PharmacyAPI.Models.DTOs
{
    public class AddTransactionDto
    {
        public decimal TotalAmount { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? TotalAmountAfterDiscount { get; set; }

        public int TransactionStatusId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; } = null!;

        public DateTime? ModifiedDate { get; set; }

        public string? ModifiedBy { get; set; }
    }
}
