using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Entities
{
    [Table("Holidays")]
   public class Holiday:AuditableEntity
    {
        public string HolidayName { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Description { get; set; }
    }
}
