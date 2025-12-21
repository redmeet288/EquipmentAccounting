using System;
using System.Collections.Generic;

namespace EA_DAL.Models;

public partial class Staff
{
    public int Id { get; set; }

    public string? Fio { get; set; }

    public string? Post { get; set; }

    public int? IdDivision { get; set; }

    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();

    public virtual Division? IdDivisionNavigation { get; set; }

    public virtual ICollection<TransferHistory> TransferHistoryNewEmployees { get; set; } = new List<TransferHistory>();

    public virtual ICollection<TransferHistory> TransferHistoryOldEmployees { get; set; } = new List<TransferHistory>();
}
