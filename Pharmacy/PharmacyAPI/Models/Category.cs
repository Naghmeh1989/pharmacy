using System;
using System.Collections.Generic;

namespace PharmacyAPI.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
