﻿using System;
using System.Collections.Generic;

namespace PharmacyAPI.Models;

public partial class ProductsTag
{
    public int ProductId { get; set; }

    public int TagId { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Tag Tag { get; set; } = null!;
}
