using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Entities
{
    [Table("Machines")]
     public class Machine:AuditableEntity
    {
        public int MachineNo { get; set; }
        public byte MachineType { get; set; }
        public string SerialNo { get; set; }
        public int PortNo { get; set; }
        public string MachineName { get; set; }
        public int BranchId { get; set; }
        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }
        public TimeZone TimeZone { get; set; }
        public byte AccessType { get; set; }
    }
}
