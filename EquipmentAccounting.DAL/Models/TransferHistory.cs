using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_DAL.Models
{
    public class TransferHistory
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public DateTime TransferDate { get; set; }
        public int OldEmployedd { get; set; }  // вк к Staff
        public int NewEmployedd { get; set; }  // вк к Staff
    }
}
