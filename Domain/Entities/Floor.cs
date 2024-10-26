using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Floor
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Status { get; set; } = null!;

    public Guid BranchId { get; set; }

    public DateTime CreateAt { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual ICollection<Zone> Zones { get; set; } = new List<Zone>();
}
