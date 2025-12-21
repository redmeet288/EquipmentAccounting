using System;
using System.Collections.Generic;

namespace EA_DAL.Models;

public partial class TypesOfEquipment
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();
}
