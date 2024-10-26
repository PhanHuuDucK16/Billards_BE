using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Branch
{
    public Guid Id { get; set; }

    public string? ThumbnailUrl { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreateAt { get; set; }

    public virtual ICollection<Floor> Floors { get; set; } = new List<Floor>();
}
