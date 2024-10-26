using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Booking
{
    public Guid Id { get; set; }

    public Guid TableId { get; set; }

    public double Price { get; set; }

    public Guid UserId { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreateAt { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();

    public virtual Table Table { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
