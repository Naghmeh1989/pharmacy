﻿namespace PharmacyAPI.Models.DTOs
{
    public class BrandDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public DateTime? CreateDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateOnly? ModifiedDate { get; set; }

        public string? ModifiedBy { get; set; }
    }
}
