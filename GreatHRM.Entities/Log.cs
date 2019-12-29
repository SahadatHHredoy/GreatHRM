using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Entities
{
    [Table("Logs")]
    public  class Log:Entity
    {
        public int MachineId { get; set; }
        [ForeignKey("MachineId")]
        public virtual Machine Machine { get; set; }
        public int EnrollId { get; set; }
        public DateTime DateTime { get; set; }
        public byte Mode { get; set; }
        public byte InOut { get; set; }
        public byte Event { get; set; }
    }
}
