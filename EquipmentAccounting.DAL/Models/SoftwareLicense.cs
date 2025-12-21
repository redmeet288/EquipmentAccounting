using System;
using System.Collections.Generic;

namespace EA_DAL.Models;

public partial class SoftwareLicense
{
    public int Id { get; set; }

    public string SoftwareName { get; set; } = null!;

    public string? Vendor { get; set; }

    public string LicenseKey { get; set; } = null!;

    public DateOnly? ExpirationDate { get; set; }

    public virtual ICollection<InstalledSoftware> InstalledSoftwares { get; set; } = new List<InstalledSoftware>();
}
