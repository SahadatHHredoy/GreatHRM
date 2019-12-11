using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Entities
{
    [Table("Employees")]
   public class Employee:AuditableEntity
    {
        public string ImageFile { get; set; }
        public string EmployeeName { get; set; }
        public string FatherName { get; set; }
        public string EmployeeCode { get; set; }
        public string EnrollNo { get; set; }
        public string ProximityCardNo { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        public int BranchId { get; set; }
        //[ForeignKey("BranchId")]
        //public virtual Branch Branch { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        public int DesignationId { get; set; }
        [ForeignKey("DesignationId")]
        public virtual Designation Designation { get; set; }

        public DateTime? BirthDate { get; set; }
        public  DateTime? ResignationDate { get; set; }
        public DateTime? ShiftStartDate { get; set; }
        public int OfficeTimePolicyId { get; set; }
        [ForeignKey("OfficeTimePolicyId")]
        public virtual OfficeTimePolicy OfficeTimePolicy { get; set; }

        public byte ShiftType { get; set; }
        public int ShiftId { get; set; }
        [ForeignKey("ShiftId")]
        public virtual Shift Shift { get; set; }

        public DateTime JoiningDate { get; set; }
        public bool IsAutoShift { get; set; }

        public DayOfWeek FirstWeeklyOff { get; set; }
        public DayOfWeek SecondWeeklyOff { get; set; }

        public byte SecondWOType { get; set; }
        public string HalfDayShift { get; set; }

        public int WeekTimeZone1 { get; set; }
        public int WeekTimeZone2 { get; set; }
        public int WeekTimeZone3 { get; set; }
        public int WeekTimeZone4 { get; set; }
        public DateTime? ValidityStart { get; set; }
        public DateTime? ValidityEnd { get; set; }


    }
}
