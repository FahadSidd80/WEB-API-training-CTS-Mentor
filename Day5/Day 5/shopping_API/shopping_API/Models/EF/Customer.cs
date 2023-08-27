using System;
using System.Collections.Generic;

namespace shopping_API.Models.EF;

public partial class Customer
{
    public int CId { get; set; }

    public string? CName { get; set; }

    public string? CType { get; set; }

    public int? CWalletBalance { get; set; }

    public string? CAddress { get; set; }

    public bool? CIsActive { get; set; }
}
