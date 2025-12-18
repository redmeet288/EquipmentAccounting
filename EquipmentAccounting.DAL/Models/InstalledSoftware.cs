using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentAccounting.DAL.Models
{
    public class InstalledSoftware
    {
        public int EquipmentId { get; set; }
        public int LicenseId { get; set; }  
        public DateTime InstallationDate { get; set; }
    }
}
