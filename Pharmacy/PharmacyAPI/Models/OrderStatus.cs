using System;
using System.Collections.Generic;

namespace PharmacyAPI.Models;

public partial class OrderStatus
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
