using System;
using System.Collections.Generic;

namespace PharmacyAPI.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public decimal TotalAmount { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? TotalAmountAfterDiscount { get; set; }

    public int TransactionStatusId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
