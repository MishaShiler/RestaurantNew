using System;
using System.Collections.Generic;

namespace Restaurant.DbModels;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public int RestaurantId { get; set; }

    public int ProductTypeId { get; set; }
}
