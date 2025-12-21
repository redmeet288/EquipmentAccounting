using System;
using System.Collections.Generic;

namespace EA_DAL.Models;

public partial class Division
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Director { get; set; }

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
