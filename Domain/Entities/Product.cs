using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Product
{
    public Guid Id { get; set; }

    public string ThumbnailUrl { get; set; } = null!;

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
