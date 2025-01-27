namespace PharmacyAPI.Models.DTOs
{
    public class AddProductDto
    {
        public string Name { get; set; } = null!;

        public string Price { get; set; } = null!;

        public string? DiscountedPrice { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; } = null!;

        public DateTime? ModifiedDate { get; set; }

        public string? ModifiedBy { get; set; }

        public int BrandId { get; set; }

        public int CategoryId { get; set; }
    }
}
