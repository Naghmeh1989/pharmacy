namespace PharmacyAPI.Models.DTOs
{
    public class AddCategoryDto
    {
        public string Name { get; set; } = null!;

        public DateTime? CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string? ModifiedBy { get; set; }
    }
}
