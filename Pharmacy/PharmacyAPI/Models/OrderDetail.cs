using System;
using System.Collections.Generic;

namespace PharmacyAPI.Models;

public partial class OrderDetail
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int? Quantity { get; set; }

    public int? ProductPriceAtOrderTime { get; set; }

    public int? DeliveryCharge { get; set; }

    public int OrderId { get; set; }

    public int PaymentId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int DeliveryStatusId { get; set; }

    public virtual DeliveryStatus DeliveryStatus { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
