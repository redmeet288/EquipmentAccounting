using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_DAL.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string FIO { get; set; }       
        public string Post { get; set; }      
        public int ID_Division { get; set; }  // вк к Divisions
    }
}
