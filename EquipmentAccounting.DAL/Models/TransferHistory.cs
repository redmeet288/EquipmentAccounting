using System;
using System.Collections.Generic;

namespace EA_DAL.Models;

public partial class TransferHistory
{
    public int Id { get; set; }

    public int EquipmentId { get; set; }

    public DateTime TransferDate { get; set; }

    public int? OldEmployeeId { get; set; }

    public int NewEmployeeId { get; set; }

    public virtual Equipment Equipment { get; set; } = null!;

    public virtual Staff NewEmployee { get; set; } = null!;

    public virtual Staff? OldEmployee { get; set; }
}
