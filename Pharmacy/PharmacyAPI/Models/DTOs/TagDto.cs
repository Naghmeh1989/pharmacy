namespace PharmacyAPI.Models.DTOs
{
    public class TagDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; } = null!;

        public DateTime ModifiedDate { get; set; }

        public string ModifiedBy { get; set; } = null!;
    }
}
