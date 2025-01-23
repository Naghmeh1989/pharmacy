using System;
using System.Collections.Generic;

namespace PharmacyAPI.Models;

public partial class Order
{
    public int Id { get; set; }

    public string OrderNumber { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public int OrderStatusId { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual OrderStatus OrderStatus { get; set; } = null!;
}
