using System;
using System.Collections.Generic;

namespace EA_DAL.Models;

public partial class InstalledSoftware
{
    public int EquipmentId { get; set; }

    public int LicenseId { get; set; }

    public DateOnly InstallationDate { get; set; }

    public virtual Equipment Equipment { get; set; } = null!;

    public virtual SoftwareLicense License { get; set; } = null!;
}
