using System;
using System.Collections.Generic;

namespace AmazonApp.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public string? Category { get; set; }
}
