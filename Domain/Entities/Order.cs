using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Order
{
    public Guid Id { get; set; }

    public Guid BookingId { get; set; }

    public double Amount { get; set; }

    public string Status { get; set; } = null!;

    public Guid StaffId { get; set; }

    public DateTime CreateAt { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual User Staff { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
