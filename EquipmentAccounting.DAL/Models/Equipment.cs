using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentAccounting.DAL.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string InventoryNumber { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; } // вк к Types of e
        public string SerialNumber { get; set; }
        public int ResponsibleStaffId { get; set; } // вк к Staff
        public DateTime RegistrationDate { get; set; }
        public string Status { get; set; } // "В работе", "На списании", "В ремонте"
    }
}
