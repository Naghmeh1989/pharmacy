namespace PharmacyAPI.Models.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }

        public string OrderNumber { get; set; } = null!;

        public DateTime? CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string? ModifiedBy { get; set; }

        public int OrderStatusId { get; set; }
    }
}
