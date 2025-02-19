namespace PharmacyAPI.Models.DTOs
{
    public class AddressDto
    {
        public int Id { get; set; }

        public string Country { get; set; } = null!;

        public string City { get; set; } = null!;

        public string StreetName { get; set; } = null!;

        public string HouseNumber { get; set; } = null!;

        public int FlatNumber { get; set; }

        public string? PostCode { get; set; }

        public string? MobileNumber { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string? ModifiedBy { get; set; }
        public int UserId { get; set; }
    }
}
