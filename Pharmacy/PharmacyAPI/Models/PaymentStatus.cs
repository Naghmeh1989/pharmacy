using System;
using System.Collections.Generic;

namespace PharmacyAPI.Models;

public partial class PaymentStatus
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
