using System;
using System.Collections.Generic;

namespace Restaurant.DbModels;

public partial class Customer
{
    public int Id { get; set; }
    public string Username { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;
}
