using System;
using System.Collections.Generic;

namespace AmazonApp.Entities;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? CategoryDescription { get; set; }

    public string? CategoryStatus { get; set; }
}
