using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Zone
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Status { get; set; } = null!;

    public Guid FloorId { get; set; }

    public DateTime CreateAt { get; set; }

    public virtual Floor Floor { get; set; } = null!;

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
}
