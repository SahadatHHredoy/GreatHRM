using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Entities
{
    [Table("OfficeTimePolicies")]
   public class OfficeTimePolicy:AuditableEntity
    {
        [Display(Name = "Policy Name")]
        public string PolicyName { get; set; }
        [Display(Name = "Permitted Late Arrival")]
        public TimeSpan PermittedLateArrival { get; set; }
        [Display(Name = "Permited Early Departure")]
        public TimeSpan PermitedEarlyDeparture { get; set; }
        [Display(Name = "Mark as Half Day if working hour Less Than")]
        public TimeSpan HalfDayLess { get; set; }
        [Display(Name = " Mark as Absent if working hour Less Than  ")]
        public TimeSpan AbsentLess { get; set; }
        [Display(Name = " Late Arrival[HH:MM] ")]
        public TimeSpan LateArrival { get; set; }
        [Display(Name = "Show As for Late Arrival")]
        public byte ShowAsLate { get; set; }
        [Display(Name = " Early Departure [HH:MM] ")]
        public TimeSpan EarlyDeparture { get; set; }
        [Display(Name = "Show As for Ealry Departure")]
        public byte ShowAsEarly { get; set; }
        [Display(Name = "Required Punches In Day")]
        public byte RequirePunches { get; set; }
        [Display(Name = "Single Punch Only")]
        public byte SinglePunch { get; set; }

        [Display(Name = "Enable Late Comming Setting")]
        public bool EnableLate { get; set; }
        public string DetectAs { get; set; }

        [Display(Name = "No Of Late In a Month")]
        public int NumberOfLate { get; set; }
        [Display(Name = "Cut Days")]
        public string CutDays { get; set; }

        [Display(Name = "Overtime Allow Ignore Overtime")]
        public bool OvertimeAllow { get; set; }
        public TimeSpan IgnoreOvertime { get; set; }


    }
}
