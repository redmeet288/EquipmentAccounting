using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentAccounting.DAL.Models
{
    public class SoftwareLicense
    {
        public int Id { get; set; }
        public string SoftwareName { get; set; }
        public string Vendor { get; set; }
        public string LicenseKey { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
