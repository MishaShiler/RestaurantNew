using System;
using System.Collections.Generic;

namespace Restaurant.DbModels;

public partial class OrderItem
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public double Price { get; set; }
}
