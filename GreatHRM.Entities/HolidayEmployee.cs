using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Entities
{
    [Table("HolidayEmployees")]
  public  class HolidayEmployee:Entity
    {
        public int HolidayId { get; set; }
        [ForeignKey("HolidayId")]
        public virtual Holiday Holiday { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
