using System;
using System.Collections.Generic;

namespace shopping_API.Models.EF;

public partial class Order
{
    public int OId { get; set; }

    public string? OType { get; set; }

    public string? OStatus { get; set; }
}
