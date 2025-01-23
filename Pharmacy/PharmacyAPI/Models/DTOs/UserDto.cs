namespace PharmacyAPI.Models.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; } = null!;

        public DateTime ModifiedDate { get; set; }

        public string ModifiedBy { get; set; } = null!;
    }
}
