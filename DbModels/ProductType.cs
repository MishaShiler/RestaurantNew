using System;
using System.Collections.Generic;

namespace Restaurant.DbModels;

public partial class ProductType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int RestaurantId { get; set; }
}
