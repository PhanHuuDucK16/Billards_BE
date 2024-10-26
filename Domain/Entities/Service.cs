using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Service
{
    public Guid Id { get; set; }

    public Guid ProductId { get; set; }

    public Guid BookingId { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public DateTime CreateAt { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
