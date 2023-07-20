using System;
using System.Collections.Generic;

namespace Restaurant.DbModels;

public partial class Order
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public DateTime Created { get; set; }

    public int RestaurantId { get; set; }

    public string ShippingAddress { get; set; } = null!;

    public int StatusId { get; set; }

    public int OrderTypeId { get; set; }
}
