using System;
using System.Collections.Generic;

namespace EA_DAL.Models;

public partial class Equipment
{
    public int Id { get; set; }

    public string InventoryNumber { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int TypeId { get; set; }

    public string? SerialNumber { get; set; }

    public int? ResponsibleStaffId { get; set; }

    public DateTime RegistrationDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<InstalledSoftware> InstalledSoftwares { get; set; } = new List<InstalledSoftware>();

    public virtual Staff? ResponsibleStaff { get; set; }

    public virtual ICollection<TransferHistory> TransferHistories { get; set; } = new List<TransferHistory>();

    public virtual TypesOfEquipment Type { get; set; } = null!;
}
