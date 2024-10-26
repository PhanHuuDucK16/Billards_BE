using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Table
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Status { get; set; } = null!;

    public double Price { get; set; }

    public Guid ZoneId { get; set; }

    public Guid CategoryId { get; set; }

    public Guid BrandId { get; set; }

    public DateTime CreateAt { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Brand Brand { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual Zone Zone { get; set; } = null!;
}
