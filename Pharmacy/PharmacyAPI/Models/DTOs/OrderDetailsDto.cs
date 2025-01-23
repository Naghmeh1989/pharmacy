namespace PharmacyAPI.Models.DTOs
{
    public class OrderDetailsDto
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int? Quantity { get; set; }

        public int? ProductPriceAtOrderTime { get; set; }

        public int? DeliveryCharge { get; set; }

        public int OrderId { get; set; }

        public int PaymentId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; } = null!;

        public DateTime ModifiedDate { get; set; }

        public string ModifiedBy { get; set; } = null!;

        public int DeliveryStatusId { get; set; }
    }
}
