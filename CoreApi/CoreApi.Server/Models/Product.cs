﻿using System;
using System.Collections.Generic;

namespace CoreApi.Server.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
}
