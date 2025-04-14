using System;
using System.Collections.Generic;

namespace coreapi1.Server.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }
}
