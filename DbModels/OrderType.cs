﻿using System;
using System.Collections.Generic;

namespace Restaurant.DbModels;

public partial class OrderType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
