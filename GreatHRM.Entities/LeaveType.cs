using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Entities
{
    [Table("LeaveTypes")]
  public  class LeaveType:AuditableEntity
    {
        public int LeaveCode { get; set; }
        public string TypeName { get; set; }
        public bool WeeklyOffInclue { get; set; }
        public bool HolidayInclude { get; set; }
        public bool PaidLeave { get; set; }
        public bool IsLeaveCarryForward { get; set; }
    }
}
