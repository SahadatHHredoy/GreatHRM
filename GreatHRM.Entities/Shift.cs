using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Entities
{
    [Table("Shifts")]
    public class Shift : AuditableEntity
    {
        public string ShiftName { get; set; }
        public string ShiftCode { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public TimeSpan Duration { get; set; }

        [Display(Name ="Begin")]
        public TimeSpan Break1Begin { get; set; }
        [Display(Name = "End")]
        public TimeSpan Break1End { get; set; }
        [Display(Name = "Duration")]
        public TimeSpan Break1Duration { get; set; }
        [Display(Name = "Begin")]
        public TimeSpan Break2Begin { get; set; }
        [Display(Name = "End")]
        public TimeSpan Break2End { get; set; }
        [Display(Name = "Duration")]
        public TimeSpan Break2Duration { get; set; }
        public string ShiftDetail { get; set; }

        public DayOfWeek FirstWeeklyOff { get; set; }
        public DayOfWeek SecondWeeklyOff { get; set; }

        public byte SecondWOType { get; set; }
        public string HalfDayShift { get; set; }
        public TimeSpan RemoveDuplicatePunch { get; set; }
        public TimeSpan MaxEarlyHourAllow { get; set; }
        public TimeSpan MaxOTAllow { get; set; }
        public int NoOfPresentForWeekend { get; set; }
        public bool AAA { get; set; }
        public bool LWOL{get;set;}
        public byte SinglePunchPolicy { get; set; }
        public byte OTCalculation { get; set; }
        public byte WorkingCalculation { get; set; }

     // public ICollection<SecondWeeklyOff> SecondWeeklyOffs { get; set; }

    }
}
