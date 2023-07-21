using System;
using System.Collections.Generic;

namespace Restaurant.DbModels;

public partial class Restaurant
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;
    public object Username { get; internal set; }

    
}
